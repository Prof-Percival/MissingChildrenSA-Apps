using MCSA_API.Domain.Users;

namespace MCSA_API.Domain.Security;

public interface IJwtHelper
{
    string GenerateJwtToken(int userId, UserRole userRole);
}