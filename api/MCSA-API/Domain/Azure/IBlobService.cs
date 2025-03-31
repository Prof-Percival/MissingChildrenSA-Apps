namespace MCSA_API.Domain.Azure;

public interface IBlobService
{
    Task<string> UploadImageAsync(IFormFile file);
}