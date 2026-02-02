using BusinessManagementWebApp.Data.TransactionItems.Entities;

namespace BusinessManagementWebApp.Data.TransactionItems.GetTransactionItems;

public class GetTransactionItemsResponse
{
    public List<TransactionItem> TransactionItems { get; set; }
}
