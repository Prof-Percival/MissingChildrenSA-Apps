using MCSA_API.Domain.Dates;
using MCSA_API.Domain.Security;
using MCSA_API.Domain.Users;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace MCSA_API.Tests.Helpers;

[TestClass]
public class JwtHelperTests
{
    private JwtHelper _jwtHelper;

    [TestInitialize]
    public void Init()
    {
        var jwtSettings = new JwtSettings
        {
            SecretKey = "SuperSecretKey123456789012345678",
            Issuer = "MCSA",
            Audience = "MCSAUsers",
            ExpirationMinutes = 60
        };

        var dateProvider = new DateProvider();

        _jwtHelper = new JwtHelper(Options.Create(jwtSettings), dateProvider);
    }

    [TestMethod]
    public void GenerateJwtToken_ValidInput_ReturnsToken()
    {
        var handler = new JwtSecurityTokenHandler();

        var (token, role, expiry) = _jwtHelper.GenerateJwtToken(1, UserRole.SuperUser);

        Assert.IsFalse(string.IsNullOrWhiteSpace(token));

        var jwt = handler.ReadJwtToken(token);

        var nameClaim = jwt.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name);
        var roleClaim = jwt.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);

        Assert.AreEqual("1", nameClaim?.Value);
        Assert.AreEqual("SuperUser", roleClaim?.Value);
    }
}