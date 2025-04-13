using MCSA_API.Domain.MissingPersons;
using MCSA_API.Models.MissingPersons;
using MCSA_API.Models.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCSA_API.Controllers;

[ApiController]
[ApiVersion("1.0-mcsa")]
[Route("api/[controller]")]
[Authorize(Roles = "SuperUser,OperationalSupport")]
public class MissingPersonController(
    IMissingPersonService missingPersonService) : BaseApiController
{
    [HttpPost("create")]
    [AllowAnonymous]
    [Produces(typeof(CreateMissingPersonResponse))]
    public async Task<IActionResult> Create([FromBody] CreateMissingPersonRequest request)
    {
        if (!ModelState.IsValid) return BadRequest("Invalid request");

        var (error, id) = await missingPersonService.CreateMissingPersonAsync(request);

        if (error != null) return BadRequest(error);

        var missingPerson = await missingPersonService.GetMissingPersonByIdAsync(id);

        return Ok(new CreateMissingPersonResponse(missingPerson));
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update([FromBody] UpdateMissingPersonRequest request)
    {
        if (!ModelState.IsValid) return BadRequest("Invalid request");

        var result = await missingPersonService.UpdateMissingPersonAsync(request);

        if (result != null) return NotFound(result);

        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await missingPersonService.GetMissingPersonByIdAsync(id);

        if (result == null) return NotFound("Missing person not found.");

        return Ok(new MissingPersonModel(result));
    }
}