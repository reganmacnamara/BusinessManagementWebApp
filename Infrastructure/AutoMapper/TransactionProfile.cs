using AutoMapper;
using InvoiceAutomationWebApp.Data.Transactions.CreateTransaction;
using InvoiceAutomationWebApp.Data.Transactions.DeleteTransaction;
using InvoiceAutomationWebApp.Data.Transactions.Entities;
using InvoiceAutomationWebApp.Data.Transactions.UpdateTransaction;

namespace InvoiceAutomationWebApp.Infrastructure.AutoMapper
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

