namespace MacsBusinessManagementWebApp.Infrastructure.Services.Auth;

public class AuthTokenService
{
    public string? Token { get; private set; }
    public bool IsAuthenticated => !string.IsNullOrEmpty(Token);

    public void SetToken(string token)
        => Token = token;

    public void ClearToken()
        => Token = null;
}
