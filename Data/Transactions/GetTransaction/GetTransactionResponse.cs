using InvoiceAutomationWebApp.Data.TransactionItems.Entities;
using InvoiceAutomationWebApp.Data.Transactions.Entities;

namespace InvoiceAutomationWebApp.Data.Transactions.GetTransaction
{

    public class GetTransactionResponse
    {
        public Transaction Transaction { get; set; } = default!;

        public List<TransactionItem> TransactionItems { get; set; } = [];
    }

}
