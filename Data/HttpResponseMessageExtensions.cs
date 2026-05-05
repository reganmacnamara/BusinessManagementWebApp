namespace MacsBusinessManagementWebApp.Data;

public static class HttpResponseMessageExtensions
{
    public static async Task<string> GetErrorBodyAsync(this HttpResponseMessage response)
    {
        var body = await response.Content.ReadAsStringAsync();
        return string.IsNullOrWhiteSpace(body) ? response.ReasonPhrase ?? string.Empty : body;
    }

    public static string? GetDownloadFileName(this HttpResponseMessage response)
    {
        var fileName = response.Content.Headers.ContentDisposition?.FileNameStar
            ?? response.Content.Headers.ContentDisposition?.FileName;

        if (string.IsNullOrWhiteSpace(fileName) &&
            response.Headers.TryGetValues("Content-Disposition", out var values) &&
            System.Net.Http.Headers.ContentDispositionHeaderValue.TryParse(values.FirstOrDefault(), out var disposition))
        {
            fileName = disposition.FileNameStar ?? disposition.FileName;
        }

        return string.IsNullOrWhiteSpace(fileName) ? null : fileName.Trim('"');
    }
}
