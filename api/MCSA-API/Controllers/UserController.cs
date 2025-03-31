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

        var user = new User
        {
            Username = request.Username,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Role = request.UserRole.Value
        };

        var newUser = await userService.CreateUserAsync(user, request.Password);

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
}