using MCSA_API.Domain.Security;
using Microsoft.AspNetCore.Identity;

namespace MCSA_API.Domain.Users;

public class UserService(
    IUserRepository userRepository,
    IJwtHelper jwtHelper) : IUserService
{
    private readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

    public async Task<string> AuthenticateUserAsync(string username, string password)
    {
        var user = await userRepository.GetByUsernameAsync(username);

        if (user == null)
        {
            return null; // Invalid credentials
        }

        // Verify password
        var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(new User(), user.PasswordHash, password);

        if (passwordVerificationResult == PasswordVerificationResult.Failed)
        {
            return null; // Invalid password
        }

        return jwtHelper.GenerateJwtToken(user.Id.Value, user.Role);
    }

    public async Task<User> CreateUserAsync(User user, string password)
    {
        // Hash and Salt the password before saving
        user.PasswordHash = _passwordHasher.HashPassword(user, password);

        await userRepository.UpsertAsync(user);

        return user;
    }
}