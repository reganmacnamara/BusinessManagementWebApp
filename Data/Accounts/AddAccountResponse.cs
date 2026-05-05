namespace MacsBusinessManagementWebApp.Data.Accounts;

public class AddAccountResponse
{
    public long AccountID { get; set; }
    public string Email { get; set; } = string.Empty;
    public long CompanyID { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
}
