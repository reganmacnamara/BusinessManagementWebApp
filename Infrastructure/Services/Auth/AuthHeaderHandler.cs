using System.Net.Http.Headers;

namespace MacsBusinessManagementWebApp.Infrastructure.Services.Auth;

public class AuthHeaderHandler(AuthTokenService tokenService) : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (tokenService.IsAuthenticated)
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenService.Token);

        return base.SendAsync(request, cancellationToken);
    }
}
