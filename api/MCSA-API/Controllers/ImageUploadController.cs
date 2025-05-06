using MCSA_API.Domain.Azure;
using MCSA_API.Models.Images;
using Microsoft.AspNetCore.Mvc;

namespace MCSA_API.Controllers;

[ApiController]
[ApiVersion("1.0-mcsa")]
[Route("api/[controller]")]
public sealed class ImageUploadController(
    IBlobService blobService) : BaseApiController
{
    [HttpPost("upload-image")]
    [Produces(typeof(ImageMetadataModel))]
    public async Task<IActionResult> UploadImageAsync([FromForm] UploadImageRequest request)
    {
        if (request == null ||
            request.File == null ||
            request.File.Length == 0)
        {
            return BadRequest("No file uploaded.");
        }

        var metadata = await blobService.UploadImageAsync(request.File);

        return Ok(new ImageMetadataModel(metadata));
    }
}