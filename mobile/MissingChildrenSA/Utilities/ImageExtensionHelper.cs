namespace MissingChildrenSA.Utilities;

public static class ImageExtensionHelper
{
    public static string GetContentType(string imagePath)
    {
        var extension = Path.GetExtension(imagePath).ToLowerInvariant();

        return extension switch
        {
            ".jpg" or ".jpeg" => "image/jpeg",
            ".png" => "image/png",
            ".gif" => "image/gif",
            ".bmp" => "image/bmp",
            _ => "application/octet-stream" // fallback for unknown types
        };
    }
}