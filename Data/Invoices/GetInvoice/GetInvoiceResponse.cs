using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.Invoices.GetInvoice;

public class GetInvoiceResponse
{
    public Invoice Invoice { get; set; }

    public List<InvoiceItem> InvoiceItems { get; set; } = [];
}
