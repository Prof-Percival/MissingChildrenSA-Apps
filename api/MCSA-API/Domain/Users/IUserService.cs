using MCSA_API.Models.Users;

namespace MCSA_API.Domain.Users;

public interface IUserService
{
    Task<string> AuthenticateUserAsync(string username, string password);
    Task<Tuple<string, User>> CreateUserAsync(CreateUserRequest request);
    Task<Tuple<string, User>> UpdateUserAsync(int userId, UpdateUserRequest request);
}