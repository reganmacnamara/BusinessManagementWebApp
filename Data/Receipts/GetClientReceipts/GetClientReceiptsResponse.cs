using BusinessManagementWebApp.Data.Entities;

namespace BusinessManagementWebApp.Data.Receipts.GetClientReceipts;

public class GetClientReceiptsResponse
{
    public List<Receipt> Receipts { get; set; } = [];
}
