using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.CompanySettings.GetCompanySettings;

public class GetCompanySettingsResponse
{
    public Entities.CompanySettings CompanySettings { get; set; } = new();
}
