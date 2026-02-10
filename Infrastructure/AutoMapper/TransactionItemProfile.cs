using AutoMapper;
using BusinessManagementWebApp.Data.Entities;
using BusinessManagementWebApp.Data.TransactionItems.DeleteTransactionItem;
using BusinessManagementWebApp.Data.TransactionItems.UpsertTransactionItem;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper;

public class TransactionItemProfile : Profile
{
    public TransactionItemProfile()
    {
        CreateMap<TransactionItem, DeleteTransactionItemRequest>();

        CreateMap<TransactionItem, UpsertTransactionItemRequest>();
    }
}
