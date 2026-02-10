using AutoMapper;
using BusinessManagementWebApp.Data.Clients.CreateClient;
using BusinessManagementWebApp.Data.Clients.DeleteClient;
using BusinessManagementWebApp.Data.Clients.UpdateClient;
using BusinessManagementWebApp.Data.Entities;

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
