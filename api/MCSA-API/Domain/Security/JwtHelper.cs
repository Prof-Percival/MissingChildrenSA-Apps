using MCSA_API.Domain.Dates;
using MCSA_API.Domain.Users;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MCSA_API.Domain.Security;

public class JwtHelper : IJwtHelper
{
    private readonly JwtSettings _jwtSettings;
    private readonly IDateProvider _dateProvider;

    public JwtHelper(
        IOptions<JwtSettings> jwtSettings,
        IDateProvider dateProvider)
    {
        _jwtSettings = jwtSettings.Value;
        _dateProvider = dateProvider;
    }

    public Tuple<string, DateTime> GenerateJwtToken(int userId, UserRole userRole)
    {
        var claims = new Claim[]
        {
            new Claim(ClaimTypes.Name, userId.ToString()),
            new Claim(ClaimTypes.Role, userRole.ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenHandler = new JwtSecurityTokenHandler();

        var expires = _dateProvider.GetDate().AddMinutes(_jwtSettings.ExpirationMinutes);

        var token = new JwtSecurityToken(
            _jwtSettings.Issuer,
            _jwtSettings.Audience,
            claims,
            expires: expires,
            signingCredentials: creds
        );

        var jwt = tokenHandler.WriteToken(token);

        return Tuple.Create(jwt, expires);
    }
}