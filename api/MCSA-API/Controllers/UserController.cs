using MCSA_API.Domain.Security;
using MCSA_API.Domain.Users;
using MCSA_API.Helpers;
using MCSA_API.Models.Shared;
using MCSA_API.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCSA_API.Controllers;

[ApiVersion("1.0-mcsa")]
[Route("api/[controller]")]
[Authorize]
public class UserController(
    IUserService userService,
    ICurrentUserService currentUserService) : BaseApiController
{
    [Authorize(Roles = "SuperUser")]
    [HttpPost("create-user")]
    [Produces(typeof(CreateUserResponse))]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("One or more fields have validation errors.");
        }

        var result = await userService.CreateUserAsync(request);

        if (result.Item1 != null)
        {
            return BadRequest(result.Item1);
        }

        var newUser = result.Item2;

        return Ok(new CreateUserResponse
        {
            Id = newUser.Id.Value,
            Username = newUser.Username,
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            UserRole = newUser.Role.GetBestDescription(),
            Created = FormattingHelper.FormatDateTime(newUser.Created)
        });
    }

    [Authorize(Roles = "SuperUser")]
    [HttpPut("update-user/{userId}")]
    [Produces(typeof(UpdateUserResponse))]
    public async Task<IActionResult> UpdateUser(int userId, [FromBody] UpdateUserRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("One or more fields have validation errors.");
        }

        var result = await userService.UpdateUserAsync(userId, request);

        if (result.Item1 != null)
        {
            return NotFound(result.Item1);
        }

        var updatedUser = result.Item2;

        return Ok(new UpdateUserResponse
        {
            Id = updatedUser.Id.Value,
            Username = updatedUser.Username,
            FirstName = updatedUser.FirstName,
            LastName = updatedUser.LastName,
            UserRole = updatedUser.Role.GetBestDescription(),
            Created = FormattingHelper.FormatDateTime(updatedUser.Created),
            Updated = FormattingHelper.FormatDateTime(updatedUser.Updated)
        });
    }

    [Authorize(Roles = "SuperUser")]
    [HttpGet("list-users")]
    [Produces(typeof(PagedUsersResponse))]
    public async Task<IActionResult> GetUsers([FromQuery] PaginationRequest request)
    {
        if (request.PageNumber < 1 || request.PageSize < 1)
        {
            return BadRequest("Page number and page size must be greater than 0.");
        }

        var result = await userService.GetUsersAsync(request.PageNumber, request.PageSize);

        return Ok(new PagedUsersResponse
        {
            TotalCount = result.TotalCount,
            PageNumber = result.PageNumber,
            PageSize = result.PageSize,
            Users = result.Users.ConvertAll(user => new GetUserResponse(user))
        });
    }

    [Authorize(Roles = "SuperUser")]
    [HttpGet("get-user-by-username/{username}")]
    [Produces(typeof(GetUserResponse))]
    public async Task<IActionResult> GetUserByUsername(string username)
    {
        var result = await userService.GetUserByUsernameAsync(username);

        if (result == null)
        {
            return NotFound("User not found.");
        }

        return Ok(new GetUserResponse(result));
    }

    [Authorize(Roles = "SuperUser")]
    [HttpGet("get-user-by-id/{userId}")]
    [Produces(typeof(GetUserResponse))]
    public async Task<IActionResult> GetUserById(int userId)
    {
        var result = await userService.GetUserByIdAsync(userId);

        if (result == null)
        {
            return NotFound("User not found.");
        }

        return Ok(new GetUserResponse(result));
    }

    [HttpGet("me")]
    [Produces(typeof(CurrentUserModel))]
    public async Task<ActionResult<CurrentUserModel>> GetCurrentUserAsync()
    {
        var user = await currentUserService.GetUserAsync();

        return Ok(new CurrentUserModel(user));
    }
}