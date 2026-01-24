using InvoiceAutomationWebApp.Data.TransactionItems.Entities;

namespace InvoiceAutomationWebApp.Data.TransactionItems.GetTransactionItems;

public class GetTransactionItemsResponse
{
    public List<TransactionItem> TransactionItems { get; set; }
}
