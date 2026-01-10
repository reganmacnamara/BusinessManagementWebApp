using InvoiceAutomationWebApp.Data.Transactions.Entities;

namespace InvoiceAutomationWebApp.Data.Transactions.GetClientTransactions
{

    public class GetClientTransactionsResponse
    {
        public List<Transaction> Transactions { get; set; }
    }
}

