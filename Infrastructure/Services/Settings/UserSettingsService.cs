using Microsoft.JSInterop;
using System.Text.Json;

namespace MacsBusinessManagementWebApp.Infrastructure.Services.Settings;

public class UserSettings
{
    public string InvoiceRefPrefix { get; set; } = string.Empty;
    public string ReceiptRefPrefix { get; set; } = string.Empty;
    public bool InvoiceAutoIncrement { get; set; }
    public bool ReceiptAutoIncrement { get; set; }
    public int NextInvoiceNumber { get; set; } = 1;
    public int NextReceiptNumber { get; set; } = 1;
}

public class UserSettingsService(IJSRuntime js)
{
    private const string StorageKey = "user_settings";

    public async Task<UserSettings> GetSettingsAsync()
    {
        try
        {
            var json = await js.InvokeAsync<string?>("localStorage.getItem", StorageKey);
            if (!string.IsNullOrEmpty(json))
                return JsonSerializer.Deserialize<UserSettings>(json) ?? new();
        }
        catch { }
        return new();
    }

    public async Task SaveSettingsAsync(UserSettings settings)
    {
        var json = JsonSerializer.Serialize(settings);
        await js.InvokeVoidAsync("localStorage.setItem", StorageKey, json);
    }

    public async Task<string?> GenerateInvoiceRefAsync()
    {
        var settings = await GetSettingsAsync();
        if (string.IsNullOrEmpty(settings.InvoiceRefPrefix) && !settings.InvoiceAutoIncrement)
            return null;

        var reference = settings.InvoiceRefPrefix;
        if (settings.InvoiceAutoIncrement)
        {
            reference += settings.NextInvoiceNumber.ToString("D4");
            settings.NextInvoiceNumber++;
            await SaveSettingsAsync(settings);
        }

        return reference;
    }

    public async Task<string?> GenerateReceiptRefAsync()
    {
        var settings = await GetSettingsAsync();
        if (string.IsNullOrEmpty(settings.ReceiptRefPrefix) && !settings.ReceiptAutoIncrement)
            return null;

        var reference = settings.ReceiptRefPrefix;
        if (settings.ReceiptAutoIncrement)
        {
            reference += settings.NextReceiptNumber.ToString("D4");
            settings.NextReceiptNumber++;
            await SaveSettingsAsync(settings);
        }

        return reference;
    }
}
