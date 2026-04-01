using AutoMapper;
using MacsBusinessManagementWebApp.Data.Entities;
using MacsBusinessManagementWebApp.Data.PaymentTerms.CreatePaymentTerm;
using MacsBusinessManagementWebApp.Data.PaymentTerms.DeletePaymentTerm;
using MacsBusinessManagementWebApp.Data.PaymentTerms.UpdatePaymentTerm;

namespace MacsBusinessManagementWebApp.Infrastructure.AutoMapper
{

    public class PaymentTermProfile : Profile
    {

        public PaymentTermProfile()
        {
            CreateMap<PaymentTerm, CreatePaymentTermRequest>();
            CreateMap<PaymentTerm, DeletePaymentTermRequest>();
            CreateMap<PaymentTerm, UpdatePaymentTermRequest>();
        }

    }

}
