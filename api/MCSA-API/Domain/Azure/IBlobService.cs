namespace MCSA_API.Domain.Azure;

public interface IBlobService
{
    Task<string> UploadImageUniqueNameAsync(IFormFile file);
    Task<ImageMetadata> UploadImageAsync(IFormFile file);
}