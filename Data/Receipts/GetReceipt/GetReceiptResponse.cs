using BusinessManagementWebApp.Data.Entities;

namespace BusinessManagementWebApp.Data.Receipts.GetReceipt;

public class GetReceiptResponse
{
    public Receipt Receipt { get; set; }

    public List<ReceiptItem> ReceiptItems { get; set; } = [];
}
