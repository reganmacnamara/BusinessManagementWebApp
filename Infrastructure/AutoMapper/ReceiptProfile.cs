using AutoMapper;
using MacsBusinessManagementWebApp.Data.Entities;
using MacsBusinessManagementWebApp.Data.Receipts.CreateReceipt;
using MacsBusinessManagementWebApp.Data.Receipts.UpdateReceipt;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper;

public class ReceiptProfile : Profile
{
    public ReceiptProfile()
    {
        CreateMap<Receipt, CreateReceiptRequest>();
        CreateMap<Receipt, UpdateReceiptRequest>();
    }
}
