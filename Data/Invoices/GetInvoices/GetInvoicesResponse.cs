using BusinessManagementWebApp.Data.Entities;

namespace BusinessManagementWebApp.Data.Invoices.GetInvoices;

public class GetInvoicesResponse
{
    public List<Invoice> Invoices { get; set; } = [];
}
