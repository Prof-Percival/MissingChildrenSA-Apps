using MCSA_API.Domain.Users;
using System.Security.Claims;

namespace MCSA_API.Domain.Security;

/// <summary>
/// Service to retrieve information about the currently authenticated user.
/// </summary>
public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentUserService"/> class.
    /// </summary>
    /// <param name="httpContextAccessor">The HTTP context accessor to retrieve information from the current HTTP request context.</param>
    /// <param name="userRepository">The user repository used to fetch user details from the database.</param>
    public CurrentUserService(
        IHttpContextAccessor httpContextAccessor,
        IUserRepository userRepository)
    {
        _httpContextAccessor = httpContextAccessor;
        _userRepository = userRepository;
    }

    /// <summary>
    /// Retrieves the UserId of the currently logged-in user.
    /// </summary>
    /// <returns>
    /// The UserId of the currently logged-in user, or <c>null</c> if the user is not authenticated or the UserId is not available.
    /// </returns>
    public int? GetUserId()
    {
        // Get the UserId claim from the current HTTP context
        var userId = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Name);

        // Try to parse the UserId as an integer
        if (int.TryParse(userId, out var id))
        {
            return id;
        }

        return null;
    }

    /// <summary>
    /// Retrieves the full user details of the currently logged-in user asynchronously.
    /// </summary>
    /// <returns>
    /// A <see cref="Task{User}"/> that represents the asynchronous operation. The result contains the details of the currently logged-in user, 
    /// or <c>null</c> if the user is not authenticated or the user details cannot be found.
    /// </returns>
    public async Task<User> GetUserAsync()
    {
        // Retrieve the UserId of the currently logged-in user
        var userId = GetUserId();

        // If the UserId is available, retrieve the full user details asynchronously
        if (userId.HasValue)
        {
            var user = await _userRepository.GetByIdAsync(userId.Value);

            return user;
        }

        return null;
    }

    /// <summary>
    /// Checks whether the currently logged-in user is authenticated.
    /// </summary>
    /// <returns>
    /// <c>true</c> if the user is authenticated, otherwise <c>false</c>.
    /// </returns>
    public bool IsAuthenticated()
    {
        // Check if the user is authenticated in the current HTTP context
        return _httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated ?? false;
    }
}
