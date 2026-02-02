using AutoMapper;
using BusinessManagementWebApp.Data.Clients.CreateClient;
using BusinessManagementWebApp.Data.Clients.DeleteClient;
using BusinessManagementWebApp.Data.Clients.Entities;
using BusinessManagementWebApp.Data.Clients.UpdateClient;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper
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
