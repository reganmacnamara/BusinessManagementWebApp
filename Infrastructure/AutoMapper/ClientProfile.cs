using AutoMapper;
using InvoiceAutomationWebApp.Data.Clients.CreateClient;
using InvoiceAutomationWebApp.Data.Clients.Entities;

namespace InvoiceAutomationWebApp.Infrastructure.AutoMapper
{

    public class ClientProfile : Profile
    {

        public ClientProfile()
        {
            CreateMap<Client, CreateClientRequest>();
        }

    }

}
