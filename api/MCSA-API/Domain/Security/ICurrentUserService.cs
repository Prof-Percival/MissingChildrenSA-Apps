using MCSA_API.Domain.Users;

namespace MCSA_API.Domain.Security;

public interface ICurrentUserService
{
    int? GetUserId();
    Task<User> GetUserAsync();
    bool IsAuthenticated();
}