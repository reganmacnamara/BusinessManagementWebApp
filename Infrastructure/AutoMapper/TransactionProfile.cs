using AutoMapper;
using BusinessManagementWebApp.Data.Transactions.CreateTransaction;
using BusinessManagementWebApp.Data.Transactions.DeleteTransaction;
using BusinessManagementWebApp.Data.Transactions.UpdateTransaction;
using System.Transactions;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper
{

    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, DeleteTransactionRequest>();

            CreateMap<Transaction, CreateTransactionRequest>();

            CreateMap<Transaction, UpdateTransactionRequest>();
        }
    }
}

