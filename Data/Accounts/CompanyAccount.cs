namespace MacsBusinessManagementWebApp.Data.Accounts;

public class CompanyAccount
{
    public long AccountID { get; set; }
    public string Email { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastLoginDate { get; set; }
}
