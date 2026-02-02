namespace BusinessManagementWebApp.Data.Transactions.UpdateTransaction;

public class UpdateTransactionRequest
{
    public long TransactionId { get; set; }

    public DateTime DueDate { get; set; }

}
