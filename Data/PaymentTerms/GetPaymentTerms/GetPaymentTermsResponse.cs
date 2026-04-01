using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.PaymentTerms.GetPaymentTerms;

public class GetPaymentTermsResponse
{
    public List<PaymentTerm> PaymentTerms { get; set; } = [];
}
