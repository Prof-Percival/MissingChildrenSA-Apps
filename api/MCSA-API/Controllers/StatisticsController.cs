using MCSA_API.Domain.Statistics;
using MCSA_API.Models.Statistics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCSA_API.Controllers;

[ApiController]
[ApiVersion("1.0-mcsa")]
[Route("api/[controller]")]
[Authorize]
public class StatisticsController(
    IStatisticsService service) : BaseApiController
{
    [HttpGet("get-main-statistics")]
    [Produces(typeof(MainStatisticsModel))]
    public async Task<IActionResult> GetMainStatistics()
    {
        var statistics = await service.GetMainStatisticsAsync();

        return Ok(MainStatisticsModel.Create(statistics));
    }

    [HttpGet("get-missing-persons-statistics")]
    [AllowAnonymous]
    [Produces(typeof(MissingPersonsStatisticsModel))]
    public async Task<IActionResult> GetMissingPersonsStatistics()
    {
        var statistics = await service.GetMissingPersonsStatistics();

        return Ok(MissingPersonsStatisticsModel.Create(statistics));
    }
}