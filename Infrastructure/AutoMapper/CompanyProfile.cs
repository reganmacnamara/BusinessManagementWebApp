using AutoMapper;
using MacsBusinessManagementWebApp.Data.Companies.UpdateCompany;
using MacsBusinessManagementWebApp.Data.CompanySettings.UpsertCompanySettings;
using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper
{

    public class CompanyProfile : Profile
    {

        public CompanyProfile()
        {
            CreateMap<Company, UpdateCompanyRequest>();
            CreateMap<CompanySettings, UpsertCompanySettingsRequest>();
        }

    }

}
