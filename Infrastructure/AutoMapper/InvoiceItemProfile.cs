using AutoMapper;
using BusinessManagementWebApp.Data.Entities;
using BusinessManagementWebApp.Data.Invoices.UpsertInvoiceItem;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper;

public class InvoiceItemProfile : Profile
{
    public InvoiceItemProfile()
    {
        CreateMap<InvoiceItem, UpsertInvoiceItemRequest>();
    }
}
