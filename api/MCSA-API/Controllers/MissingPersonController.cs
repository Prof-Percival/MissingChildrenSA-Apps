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
    [HttpPost("report-missing-person")]
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

    [HttpPut("update-missing-person")]
    public async Task<IActionResult> Update([FromBody] UpdateMissingPersonRequest request)
    {
        if (!ModelState.IsValid) return BadRequest("Invalid request");

        var result = await missingPersonService.UpdateMissingPersonAsync(request);

        if (result != null) return NotFound(result);

        return Ok();
    }

    [HttpGet("list-missing-persons")]
    [Produces(typeof(PagedMissingPersonsResponse))]
    public async Task<IActionResult> GetUsers([FromQuery] PaginationRequest request)
    {
        if (request.PageNumber < 1 || request.PageSize < 1)
        {
            return BadRequest("Page number and page size must be greater than 0.");
        }

        var result = await missingPersonService.GetMissingPersonsAsync(request.PageNumber, request.PageSize);

        return Ok(new PagedMissingPersonsResponse
        {
            TotalCount = result.TotalCount,
            PageNumber = result.PageNumber,
            PageSize = result.PageSize,
            MissingPersons = result.MissingPersons.ConvertAll(missingPerson => new MissingPersonViewModel(missingPerson))
        });
    }

    [HttpGet("get-missing-person-by-id/{id}")]
    [Produces(typeof(MissingPersonViewModel))]
    public async Task<IActionResult> GetMissingPersonById(int id)
    {
        var result = await missingPersonService.GetMissingPersonByIdAsync(id);

        if (result == null) return NotFound("Missing person not found.");

        return Ok(new MissingPersonViewModel(result));
    }
}