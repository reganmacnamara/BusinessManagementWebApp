using AutoMapper;
using InvoiceAutomationWebApp.Data.Clients.CreateClient;
using InvoiceAutomationWebApp.Data.Clients.DeleteClient;
using InvoiceAutomationWebApp.Data.Clients.Entities;
using InvoiceAutomationWebApp.Data.Clients.UpdateClient;

namespace InvoiceAutomationWebApp.Infrastructure.AutoMapper
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
