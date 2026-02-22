using AutoMapper;
using BusinessManagementWebApp.Data.Entities;
using BusinessManagementWebApp.Data.Receipts.CreateReceipt;
using BusinessManagementWebApp.Data.Receipts.UpdateReceipt;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper;

public class ReceiptProfile : Profile
{
    public ReceiptProfile()
    {
        CreateMap<Receipt, CreateReceiptRequest>();
        CreateMap<Receipt, UpdateReceiptRequest>();
    }
}
