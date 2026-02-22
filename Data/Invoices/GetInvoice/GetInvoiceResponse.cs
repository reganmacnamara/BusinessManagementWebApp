using BusinessManagementWebApp.Data.Entities;

namespace BusinessManagementWebApp.Data.Invoices.GetInvoice;

public class GetInvoiceResponse
{
    public Invoice Invoice { get; set; }

    public List<InvoiceItem> InvoiceItems { get; set; } = [];
}
