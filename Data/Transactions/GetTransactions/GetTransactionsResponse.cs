using InvoiceAutomationWebApp.Data.Transactions.Entities;

namespace InvoiceAutomationWebApp.Data.Transactions.GetTransactions
{

    public class GetTransactionsResponse
    {
        public List<Transaction> Transactions { get; set; }
    }

}
