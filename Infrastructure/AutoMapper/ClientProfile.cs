using AutoMapper;
using MacsBusinessManagementWebApp.Data.Clients.CreateClient;
using MacsBusinessManagementWebApp.Data.Clients.DeleteClient;
using MacsBusinessManagementWebApp.Data.Clients.UpdateClient;
using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper
{

    public class ClientProfile : Profile
    {

        public ClientProfile()
        {
            CreateMap<Client, CreateClientRequest>();
            CreateMap<Client, DeleteClientRequest>();
            CreateMap<Client, UpdateClientRequest>();
        }

    }

}
