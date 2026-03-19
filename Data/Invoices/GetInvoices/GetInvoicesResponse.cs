using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.Invoices.GetInvoices;

public class GetInvoicesResponse
{
    public List<Invoice> Invoices { get; set; } = [];
}
