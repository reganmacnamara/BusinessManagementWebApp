using BusinessManagementWebApp.Data.Entities;

namespace BusinessManagementWebApp.Data.Receipts.GetReceipts;

public class GetReceiptsResponse
{
    public List<Receipt> Receipts { get; set; } = [];
}
