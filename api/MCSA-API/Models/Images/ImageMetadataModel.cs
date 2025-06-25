using MCSA_API.Domain.Azure;

namespace MCSA_API.Models.Images;

public sealed class ImageMetadataModel(ImageMetadata imageMetadata)
{
    public string FileName { get; } = imageMetadata.FileName;
    public string FileUrl { get; } = imageMetadata.FileUrl;
    public string ContentType { get; } = imageMetadata.ContentType;
    public long Size { get; } = imageMetadata.Size;
}