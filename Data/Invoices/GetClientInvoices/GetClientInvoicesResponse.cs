using BusinessManagementWebApp.Data.Entities;

namespace BusinessManagementWebApp.Data.Invoices.GetClientInvoices;

public class GetClientInvoicesResponse
{
    public List<Invoice> Invoices { get; set; } = [];
}
