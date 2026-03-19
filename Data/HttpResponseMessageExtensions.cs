namespace MacsBusinessManagementWebApp.Data;

public static class HttpResponseMessageExtensions
{
    public static async Task<string> GetErrorBodyAsync(this HttpResponseMessage response)
    {
        var body = await response.Content.ReadAsStringAsync();
        return string.IsNullOrWhiteSpace(body) ? response.ReasonPhrase ?? string.Empty : body;
    }
}
