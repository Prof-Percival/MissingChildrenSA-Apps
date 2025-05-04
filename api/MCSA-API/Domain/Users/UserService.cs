using MCSA_API.Domain.Security;
using MCSA_API.Helpers;
using MCSA_API.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace MCSA_API.Domain.Users;

public class UserService(
    IUserRepository userRepository,
    IJwtHelper jwtHelper) : IUserService
{
    private readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

    public async Task<Tuple<string, string, DateTime>> AuthenticateUserAsync(string username, string password)
    {
        var user = await userRepository.GetByUsernameAsync(username);

        if (user == null)
        {
            return null; // Invalid credentials
        }

        // Verify password
        var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);

        if (passwordVerificationResult == PasswordVerificationResult.Failed)
        {
            return null; // Invalid password
        }

        return jwtHelper.GenerateJwtToken(user.Id.Value, user.Role);
    }

    public async Task<Tuple<string, User>> CreateUserAsync(CreateUserRequest request)
    {
        // Check if the user already exists
        var existingUser = await userRepository.GetByUsernameAsync(request.Username);

        if (existingUser != null)
        {
            return new Tuple<string, User>("User with this username already exists.", null);
        }

        var user = new User
        {
            Username = request.Username,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Role = request.UserRole.Value
        };

        // Hash and Salt the password before saving
        user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);

        await userRepository.UpsertAsync(user);

        return new Tuple<string, User>(null, user);
    }

    public async Task<Tuple<string, User>> UpdateUserAsync(int userId, UpdateUserRequest request)
    {
        var user = await userRepository.GetByIdAsync(userId);

        if (user == null)
        {
            return new Tuple<string, User>("User not found.", null);
        }

        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.Role = request.UserRole.Value;

        // If password is provided, update it
        if (!string.IsNullOrWhiteSpace(request.Password))
        {
            user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);
        }

        await userRepository.UpsertAsync(user);

        return new Tuple<string, User>(null, user);
    }

    public async Task<PagedUsersResult> GetUsersAsync(int pageNumber, int pageSize)
    {
        var allUsers = await userRepository.GetAllAsync();

        var totalCount = allUsers.Count();

        var users = allUsers
            .Skip(PageHelper.CalculateSkip(pageSize, pageNumber))
            .Take(pageSize)
            .ToList();

        return new PagedUsersResult
        {
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize,
            Users = users
        };
    }

    public async Task<User> GetUserByUsernameAsync(string username)
    {
        return await userRepository.GetByUsernameAsync(username);
    }

    public async Task<User> GetUserByIdAsync(int userId)
    {
        return await userRepository.GetByIdAsync(userId);
    }
}