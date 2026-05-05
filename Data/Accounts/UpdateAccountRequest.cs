namespace MacsBusinessManagementWebApp.Data.Accounts;

public class UpdateAccountRequest
{
    public long AccountID { get; set; }
    public string Email { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}
