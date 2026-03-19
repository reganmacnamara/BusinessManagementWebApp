using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.Invoices.GetClientInvoices;

public class GetClientInvoicesResponse
{
    public List<Invoice> Invoices { get; set; } = [];
}
