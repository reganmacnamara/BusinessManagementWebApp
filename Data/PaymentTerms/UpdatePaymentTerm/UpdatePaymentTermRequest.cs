namespace MacsBusinessManagementWebApp.Data.PaymentTerms.UpdatePaymentTerm;

public class UpdatePaymentTermRequest
{
    public long PaymentTermID { get; set; }

    public string PaymentTermName { get; set; } = string.Empty;

    public int Days { get; set; }

    public int Months { get; set; }

    public bool EndOfMonth { get; set; }

    public int? DayOfMonth { get; set; }

    public bool OffsetFirst { get; set; }
}
