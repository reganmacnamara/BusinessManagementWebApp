using InvoiceAutomationWebApp.Data.Products.Entities;
using InvoiceAutomationWebApp.Data.Transactions.Entities;

namespace InvoiceAutomationWebApp.Data.TransactionItems.Entities;

public class TransactionItem
{
    public long TransactionItemID { get; set; }

    public long TransactionID { get; set; }

    public long ProductID { get; set; }

    public int Quantity { get; set; }

    public decimal PricePerItem { get; set; }

    public decimal LineGross { get; set; }

    public decimal LineTax { get; set; }

    public decimal LineNet { get; set; }

    public Product Product { get; set; }

    public Transaction Transaction { get; set; }
}
