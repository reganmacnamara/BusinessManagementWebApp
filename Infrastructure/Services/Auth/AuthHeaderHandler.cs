using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using MacsBusinessManagementWebApp.Data.Auth.Login;

namespace MacsBusinessManagementWebApp.Infrastructure.Services.Auth;

public class AuthHeaderHandler(AuthTokenService tokenService) : DelegatingHandler
{
    private const string RetriedKey = "x-auth-retried";
    private static readonly HttpRequestOptionsKey<bool> RetriedOption = new(RetriedKey);

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Content is not null)
            await request.Content.LoadIntoBufferAsync();

        ApplyAuthHeaders(request);

        var response = await base.SendAsync(request, cancellationToken);

        CaptureRefreshCookie(response);

        if (response.StatusCode != HttpStatusCode.Unauthorized) return response;
        if (IsAuthEndpoint(request.RequestUri)) return response;
        if (request.Options.TryGetValue(RetriedOption, out var retried) && retried) return response;
        if (string.IsNullOrEmpty(tokenService.RefreshCookie)) return response;

        var refreshed = await TryRefreshAsync(cancellationToken);
        if (!refreshed) return response;

        response.Dispose();

        var retry = await CloneAsync(request, cancellationToken);
        retry.Options.Set(RetriedOption, true);
        ApplyAuthHeaders(retry);

        var retryResponse = await base.SendAsync(retry, cancellationToken);
        CaptureRefreshCookie(retryResponse);
        return retryResponse;
    }

    private void ApplyAuthHeaders(HttpRequestMessage request)
    {
        if (!string.IsNullOrEmpty(tokenService.Token))
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenService.Token);

        if (IsAuthEndpoint(request.RequestUri) && !string.IsNullOrEmpty(tokenService.RefreshCookie))
        {
            request.Headers.Remove("Cookie");
            request.Headers.Add("Cookie", tokenService.RefreshCookie);
        }
    }

    private async Task<bool> TryRefreshAsync(CancellationToken cancellationToken)
    {
        var refreshRequest = new HttpRequestMessage(HttpMethod.Post, "/Auth/Refresh");
        ApplyAuthHeaders(refreshRequest);

        using var refreshResponse = await base.SendAsync(refreshRequest, cancellationToken);
        CaptureRefreshCookie(refreshResponse);

        if (!refreshResponse.IsSuccessStatusCode)
        {
            tokenService.ClearToken();
            return false;
        }

        var payload = await refreshResponse.Content.ReadFromJsonAsync<LoginAccountResponse>(cancellationToken: cancellationToken);
        if (payload?.Token is null) return false;

        tokenService.SetToken(payload.Token, payload.Expiry);
        return true;
    }

    private void CaptureRefreshCookie(HttpResponseMessage response)
    {
        if (!response.Headers.TryGetValues("Set-Cookie", out var setCookies)) return;

        foreach (var raw in setCookies)
        {
            if (!raw.StartsWith("refreshToken=", StringComparison.OrdinalIgnoreCase)) continue;

            var nameValue = raw.Split(';', 2)[0].Trim();
            var equalsIndex = nameValue.IndexOf('=');
            var value = equalsIndex >= 0 ? nameValue[(equalsIndex + 1)..] : string.Empty;

            if (string.IsNullOrEmpty(value))
                tokenService.SetRefreshCookie(string.Empty);
            else
                tokenService.SetRefreshCookie(nameValue);
            return;
        }
    }

    private static bool IsAuthEndpoint(Uri? uri)
        => uri is not null && uri.AbsolutePath.StartsWith("/Auth/", StringComparison.OrdinalIgnoreCase);

    private static async Task<HttpRequestMessage> CloneAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var clone = new HttpRequestMessage(request.Method, request.RequestUri) { Version = request.Version };

        if (request.Content is not null)
        {
            var bytes = await request.Content.ReadAsByteArrayAsync(cancellationToken);
            var content = new ByteArrayContent(bytes);
            foreach (var header in request.Content.Headers)
                content.Headers.TryAddWithoutValidation(header.Key, header.Value);
            clone.Content = content;
        }

        foreach (var header in request.Headers)
            clone.Headers.TryAddWithoutValidation(header.Key, header.Value);

        return clone;
    }
}
