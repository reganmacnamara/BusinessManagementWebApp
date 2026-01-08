using InvoiceAutomationWebApp.Data.Clients.Entities;

namespace InvoiceAutomationWebApp.Data.Transactions.Entities
{

    public class Transaction
    {
        public long TransactionID { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionType { get; init; }

        public DateOnly DueDate { get; set; }

        public Client Client { get; set; } = null!;

        public decimal GrossValue { get; set; }

        public decimal TaxValue { get; set; }

        public decimal NetValue { get; set; }

        public decimal OffsetValue { get; set; }
    }

}
