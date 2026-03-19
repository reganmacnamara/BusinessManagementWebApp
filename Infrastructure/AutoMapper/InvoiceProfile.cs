using AutoMapper;
using MacsBusinessManagementWebApp.Data.Entities;
using MacsBusinessManagementWebApp.Data.Invoices.CreateInvoice;
using MacsBusinessManagementWebApp.Data.Invoices.UpdateInvoice;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper;

public class InvoiceProfile : Profile
{
    public InvoiceProfile()
    {
        CreateMap<Invoice, CreateInvoiceRequest>();
        CreateMap<Invoice, UpdateInvoiceRequest>();
    }
}
