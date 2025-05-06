namespace MCSA_API.Domain.Azure;

public sealed class ImageMetadata
{
    public string FileName { get; init; }
    public string FileUrl { get; init; }
    public string ContentType { get; init; }
    public long Size { get; init; }
}