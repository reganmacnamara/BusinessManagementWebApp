using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.Receipts.GetClientReceipts;

public class GetClientReceiptsResponse
{
    public List<Receipt> Receipts { get; set; } = [];
}
