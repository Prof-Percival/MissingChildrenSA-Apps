namespace MCSA_API.Domain.Users;

public interface IUserService
{
    Task<string> AuthenticateUserAsync(string username, string password);
    Task<User> CreateUserAsync(User user, string password);
}