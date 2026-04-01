namespace MacsBusinessManagementWebApp.Data.PaymentTerms.CreatePaymentTerm;

public class CreatePaymentTermRequest
{
    public string PaymentTermName { get; set; } = string.Empty;

    public int Days { get; set; }

    public int Months { get; set; }

    public bool EndOfMonth { get; set; }

    public int? DayOfMonth { get; set; }

    public bool OffsetFirst { get; set; }
}
