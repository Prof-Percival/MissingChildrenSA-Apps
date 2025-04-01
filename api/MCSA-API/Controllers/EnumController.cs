using MCSA_API.Domain;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;
using MCSA_API.Domain.Users;
using MCSA_API.Models.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCSA_API.Controllers;

[ApiVersion("1.0-mcsa")]
[Route("api/[controller]")]
[Authorize]
public class EnumController : BaseApiController
{
    [HttpGet("genders")]
    [Produces(typeof(List<EnumValueResponse>))]
    public IActionResult GetGenders()
    {
        return Ok(EnumValueResponseHelper.GetValues<Gender>());
    }

    [HttpGet("missing-person-statuses")]
    [Produces(typeof(List<EnumValueResponse>))]
    public IActionResult GetMissingPersonStatuses()
    {
        return Ok(EnumValueResponseHelper.GetValues<MissingPersonStatus>());
    }

    [HttpGet("moderation-statuses")]
    [Produces(typeof(List<EnumValueResponse>))]
    public IActionResult GetModerationStatuses()
    {
        return Ok(EnumValueResponseHelper.GetValues<ModerationStatus>());
    }

    [HttpGet("provinces")]
    [Produces(typeof(List<EnumValueResponse>))]
    public IActionResult GetProvinces()
    {
        return Ok(EnumValueResponseHelper.GetValues<Province>());
    }

    [HttpGet("races")]
    [Produces(typeof(List<EnumValueResponse>))]
    public IActionResult GetRaces()
    {
        return Ok(EnumValueResponseHelper.GetValues<Race>());
    }

    [HttpGet("roles")]
    [Produces(typeof(List<EnumValueResponse>))]
    public IActionResult GetUserRoles()
    {
        return Ok(EnumValueResponseHelper.GetValues<UserRole>());
    }
}