using AutoMapper;
using MacsBusinessManagementWebApp.Data.Entities;
using MacsBusinessManagementWebApp.Data.Invoices.UpsertInvoiceItem;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper;

public class InvoiceItemProfile : Profile
{
    public InvoiceItemProfile()
    {
        CreateMap<InvoiceItem, UpsertInvoiceItemRequest>();
    }
}
