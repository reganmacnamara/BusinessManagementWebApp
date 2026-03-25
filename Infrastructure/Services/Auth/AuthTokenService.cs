namespace MacsBusinessManagementWebApp.Infrastructure.Services.Auth;

public class AuthTokenService
{
    public string? Token { get; private set; }
    public DateTime? Expiry { get; private set; }
    public bool IsAuthenticated => !string.IsNullOrEmpty(Token) && Expiry > DateTime.UtcNow;

    public void SetToken(string token, DateTime expiry)
    {
        Token = token;
        Expiry = expiry;
    }

    public void ClearToken()
    {
        Token = null;
        Expiry = null;
    }
}
