using AutoMapper;
using MacsBusinessManagementWebApp.Data.Entities;
using MacsBusinessManagementWebApp.Data.Services.CreateService;
using MacsBusinessManagementWebApp.Data.Services.UpdateService;
using MacsBusinessManagementWebApp.Data.Services.UpsertServiceActivity;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper
{

    public class ServiceProfile : Profile
    {

        public ServiceProfile()
        {
            CreateMap<Service, CreateServiceRequest>();
            CreateMap<Service, UpdateServiceRequest>();
            CreateMap<ServiceActivity, UpsertServiceActivityRequest>();
        }

    }

}
