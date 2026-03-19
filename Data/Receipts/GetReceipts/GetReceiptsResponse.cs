using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.Receipts.GetReceipts;

public class GetReceiptsResponse
{
    public List<Receipt> Receipts { get; set; } = [];
}
