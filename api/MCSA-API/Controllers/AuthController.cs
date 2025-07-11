using MCSA_API.Domain.Users;
using MCSA_API.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace MCSA_API.Controllers;

[ApiVersion("1.0-mcsa")]
[Route("api/[controller]")]
public class AuthController(
    IUserService userService) : BaseApiController
{
    [HttpPost("authenticate")]
    [Produces(typeof(AuthenticateResponse))]
    public async Task<IActionResult> Authenticate([FromBody] AuthenticateRequest model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Username or password is required.");
        }

        var result = await userService.AuthenticateUserAsync(model.Username, model.Password);

        if (result == null)
            return Unauthorized("Invalid username or password.");

        var (token, role, expiryDate) = result;

        return Ok(new AuthenticateResponse
        {
            Token = token,
            Role = role,
            TokenExpiry = expiryDate
        });
    }
}