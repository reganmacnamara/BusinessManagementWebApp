using System.IdentityModel.Tokens.Jwt;

namespace MacsBusinessManagementWebApp.Infrastructure.Services.Auth;

public class AuthTokenService
{
    public string? Token { get; private set; }
    public DateTime? Expiry { get; private set; }
    public bool IsAuthenticated => !string.IsNullOrEmpty(Token) && Expiry > DateTime.UtcNow;
    public bool HasCompany { get; private set; }

    public void SetToken(string token, DateTime expiry)
    {
        Token = token;
        Expiry = expiry;

        var handler = new JwtSecurityTokenHandler();
        var jwt = handler.ReadJwtToken(token);
        var companyIdClaim = jwt.Claims.FirstOrDefault(c => c.Type == "companyID");
        HasCompany = companyIdClaim is not null && long.TryParse(companyIdClaim.Value, out var id) && id > 0;
    }

    public void ClearToken()
    {
        Token = null;
        Expiry = null;
        HasCompany = false;
    }
}
