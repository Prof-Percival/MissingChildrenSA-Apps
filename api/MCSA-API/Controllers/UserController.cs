using MCSA_API.Domain.Users;
using MCSA_API.Helpers;
using MCSA_API.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCSA_API.Controllers;

[ApiVersion("1.0-mcsa")]
[Route("api/[controller]")]
[Authorize(Roles = "SuperUser")]
public class UserController(
    IUserService userService) : BaseApiController
{
    [HttpPost("create")]
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

    [HttpPut("update/{userId}")]
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

    [HttpGet("list")]
    [Produces(typeof(PagedUsersResponse))]
    public async Task<IActionResult> GetUsers([FromQuery] GetUsersRequest request)
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

    [HttpGet("{username}")]
    [Produces(typeof(GetUserResponse))]
    public async Task<IActionResult> GetUser(string username)
    {
        var result = await userService.GetUserByUsernameAsync(username);

        if (result == null)
        {
            return NotFound("User not found.");
        }

        return Ok(new GetUserResponse(result));
    }
}