using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace MacsBusinessManagementWebApp.Infrastructure.Services.Auth;

public class AuthTokenService
{
    public string? Token { get; private set; }
    public DateTime? Expiry { get; private set; }
    public bool IsAuthenticated => !string.IsNullOrEmpty(Token) && Expiry > DateTime.UtcNow;
    public long AccountID { get; private set; }
    public string? Email { get; private set; }
    public bool HasCompany { get; private set; }
    public long CompanyID { get; private set; }
    public string? RefreshCookie { get; private set; }

    public void SetToken(string token, DateTime expiry)
    {
        Token = token;
        Expiry = expiry;

        var handler = new JwtSecurityTokenHandler();
        var jwt = handler.ReadJwtToken(token);
        var accountIdClaim = jwt.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)
                             ?? jwt.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
        var companyIdClaim = jwt.Claims.FirstOrDefault(c => c.Type == "companyID");
        var emailClaim = jwt.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Email)
                         ?? jwt.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);

        AccountID = accountIdClaim is not null && long.TryParse(accountIdClaim.Value, out var accountID)
            ? accountID
            : 0;
        CompanyID = companyIdClaim is not null && long.TryParse(companyIdClaim.Value, out var companyID)
            ? companyID
            : 0;
        Email = emailClaim?.Value;
        HasCompany = CompanyID > 0;
    }

    public void SetRefreshCookie(string cookie) => RefreshCookie = cookie;

    public void ClearToken()
    {
        Token = null;
        Expiry = null;
        AccountID = 0;
        Email = null;
        HasCompany = false;
        CompanyID = 0;
        RefreshCookie = null;
    }
}
