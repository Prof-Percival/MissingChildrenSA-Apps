using Azure.Storage.Blobs;

namespace MCSA_API.Domain.Azure;

public class BlobService : IBlobService
{
    private readonly BlobServiceClient _blobServiceClient;

    public BlobService(IConfiguration configuration)
    {
        _blobServiceClient = new BlobServiceClient(configuration.GetConnectionString("AzureBlobStorage"));
    }

    public async Task<string> UploadImageAsync(IFormFile file)
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient("missingpersons");

        var blobClient = containerClient.GetBlobClient(Guid.NewGuid().ToString());

        using (var stream = file.OpenReadStream())
        {
            await blobClient.UploadAsync(stream);
        }

        return blobClient.Uri.ToString();
    }
}