using AutoMapper;
using BusinessManagementWebApp.Data.Entities;
using BusinessManagementWebApp.Data.Receipts.UpsertReceiptItem;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper;

public class ReceiptItemProfile : Profile
{
    public ReceiptItemProfile()
    {
        CreateMap<ReceiptItem, UpsertReceiptItemRequest>();
    }
}
