using MacsBusinessManagementWebApp.Data;
using MacsBusinessManagementWebApp.Data.CompanySettings.UpsertCompanySettings;
using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Infrastructure.Services.Settings;

public class UserSettingsService(ApiClient api)
{
    public async Task<CompanySettings> GetSettingsAsync()
    {
        try
        {
            var response = await api.GetCompanySettingsAsync();
            return response.CompanySettings ?? new();
        }
        catch
        {
            return new();
        }
    }

    public async Task<bool> SaveSettingsAsync(UpsertCompanySettingsRequest request)
    {
        var response = await api.UpsertCompanySettingsAsync(request);
        return response.IsSuccessStatusCode;
    }

    public async Task<string?> GenerateInvoiceRefAsync()
    {
        var settings = await GetSettingsAsync();
        if (string.IsNullOrEmpty(settings.InvoicePrefix) && !settings.AutoIncrementInvoice)
            return null;

        var reference = settings.InvoicePrefix;
        if (settings.AutoIncrementInvoice)
            reference += settings.NextInvoiceNumber.ToString("D4");

        return reference;
    }

    public async Task IncrementInvoiceNumberAsync()
    {
        var settings = await GetSettingsAsync();
        if (settings.AutoIncrementInvoice)
        {
            settings.NextInvoiceNumber++;
            await api.UpsertCompanySettingsAsync(new UpsertCompanySettingsRequest
            {
                CompanySettingsID = settings.CompanySettingsID,
                InvoicePrefix = settings.InvoicePrefix,
                NextInvoiceNumber = settings.NextInvoiceNumber,
                AutoIncrementInvoice = settings.AutoIncrementInvoice,
                ReceiptPrefix = settings.ReceiptPrefix,
                NextReceiptNumber = settings.NextReceiptNumber,
                AutoIncrementReceipt = settings.AutoIncrementReceipt,
            });
        }
    }

    public async Task<string?> GenerateReceiptRefAsync()
    {
        var settings = await GetSettingsAsync();
        if (string.IsNullOrEmpty(settings.ReceiptPrefix) && !settings.AutoIncrementReceipt)
            return null;

        var reference = settings.ReceiptPrefix;
        if (settings.AutoIncrementReceipt)
            reference += settings.NextReceiptNumber.ToString("D4");

        return reference;
    }

    public async Task IncrementReceiptNumberAsync()
    {
        var settings = await GetSettingsAsync();
        if (settings.AutoIncrementReceipt)
        {
            settings.NextReceiptNumber++;
            await api.UpsertCompanySettingsAsync(new UpsertCompanySettingsRequest
            {
                CompanySettingsID = settings.CompanySettingsID,
                InvoicePrefix = settings.InvoicePrefix,
                NextInvoiceNumber = settings.NextInvoiceNumber,
                AutoIncrementInvoice = settings.AutoIncrementInvoice,
                ReceiptPrefix = settings.ReceiptPrefix,
                NextReceiptNumber = settings.NextReceiptNumber,
                AutoIncrementReceipt = settings.AutoIncrementReceipt,
            });
        }
    }
}
