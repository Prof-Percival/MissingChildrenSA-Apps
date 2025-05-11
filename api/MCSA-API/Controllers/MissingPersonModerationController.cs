using MCSA_API.Domain.Moderation;
using MCSA_API.Models.Moderation;
using MCSA_API.Models.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCSA_API.Controllers;

[ApiController]
[ApiVersion("1.0-mcsa")]
[Route("api/[controller]")]
[Authorize(Roles = "SuperUser,OperationalSupport")]
public class MissingPersonModerationController(
    IModerationService service) : BaseApiController
{
    [HttpGet("get-moderation-queue")]
    [Produces(typeof(ModerationQueuePagedResponse))]
    public async Task<IActionResult> GetModerationQueue([FromQuery] PaginationRequest request)
    {
        if (request.PageNumber < 1 || request.PageSize < 1)
        {
            return BadRequest("Page number and page size must be greater than 0.");
        }

        var result = await service.GetModerationQueueAsync(request.PageNumber, request.PageSize);

        return Ok(result);
    }

    [HttpGet("get-queue-details/{id}")]
    [Produces(typeof(ModerationQueueItemDetailsResponse))]
    public async Task<IActionResult> GetQueueDetails(int id)
    {
        var result = await service.GetQueueDetailsAsync(id);

        if (result == null) return NotFound();

        return Ok(result);
    }

    [HttpPost("queue/{id}/start-moderation")]
    public async Task<IActionResult> StartModeration(int id)
    {
        var result = await service.StartModerationAsync(id);

        if (result != null) return BadRequest(result);

        return Ok();
    }

    [HttpPut("queue/update-moderation-status")]
    public async Task<IActionResult> UpdateModerationStatus([FromBody] ModerationStatusUpdateRequest request)
    {
        var result = await service.UpdateModerationStatusAsync(request);

        if (result != null) return BadRequest(result);

        return Ok();
    }
}