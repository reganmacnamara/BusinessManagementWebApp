using AutoMapper;
using MacsBusinessManagementWebApp.Data.Entities;
using MacsBusinessManagementWebApp.Data.Receipts.UpsertReceiptItem;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper;

public class ReceiptItemProfile : Profile
{
    public ReceiptItemProfile()
    {
        CreateMap<ReceiptItem, UpsertReceiptItemRequest>();
    }
}
