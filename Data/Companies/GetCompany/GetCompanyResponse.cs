using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.Companies.GetCompany;

public class GetCompanyResponse
{
    public Company Company { get; set; } = new();
}
