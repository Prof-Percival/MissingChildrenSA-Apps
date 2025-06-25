using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace MCSA_API.Domain.Azure;

public sealed class BlobService : IBlobService
{
    private readonly BlobServiceClient _blobServiceClient;
    private readonly string _containerName = "missingpersons";

    public BlobService(IConfiguration configuration)
    {
        _blobServiceClient = new BlobServiceClient(configuration.GetConnectionString("AzureBlobStorage"));
    }

    public async Task<string> UploadImageUniqueNameAsync(IFormFile file)
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);

        var blobClient = containerClient.GetBlobClient(Guid.NewGuid().ToString());

        using (var stream = file.OpenReadStream())
        {
            await blobClient.UploadAsync(stream);
        }

        return blobClient.Uri.ToString();
    }

    public async Task<ImageMetadata> UploadImageAsync(IFormFile file)
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);

        await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);

        var blobClient = containerClient.GetBlobClient(file.FileName);

        var headers = new BlobHttpHeaders { ContentType = file.ContentType };

        using (var stream = file.OpenReadStream())
        {
            await blobClient.UploadAsync(stream, headers);
        }

        return new ImageMetadata
        {
            FileName = file.FileName,
            FileUrl = blobClient.Uri.ToString(),
            ContentType = file.ContentType,
            Size = file.Length
        };
    }
}