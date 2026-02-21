using AutoMapper;
using BusinessManagementWebApp.Data.Entities;
using BusinessManagementWebApp.Data.TransactionAllocations.UpsertTransactionAllocation;

namespace BusinessManagementWebApp.Infrastructure.AutoMapper
{
    public class TransactionAllocationProfile : Profile
    {
        public TransactionAllocationProfile()
        {
            CreateMap<TransactionAllocation, UpsertTransactionAllocationRequest>();
        }
    }
}
