using AutoMapper;
using BusinessManagementWebApp.Data.Entities;
using BusinessManagementWebApp.Data.Invoices.CreateInvoice;
using BusinessManagementWebApp.Data.Invoices.UpdateInvoice;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper;

public class InvoiceProfile : Profile
{
    public InvoiceProfile()
    {
        CreateMap<Invoice, CreateInvoiceRequest>();
        CreateMap<Invoice, UpdateInvoiceRequest>();
    }
}
