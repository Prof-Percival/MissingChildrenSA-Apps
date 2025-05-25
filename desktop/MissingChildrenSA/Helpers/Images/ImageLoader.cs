namespace MissingChildrenSA.Helpers.Images;

public static class ImageLoader
{
    public static async Task LoadImageFromUrl(
        this PictureBox picture,
        string imageUrl)
    {
        try
        {
            using var client = new HttpClient();

            var imageBytes = await client.GetByteArrayAsync(imageUrl);

            using var ms = new MemoryStream(imageBytes);

            picture.Image = Image.FromStream(ms);
        }
        catch
        {
            picture.Image = null;
        }
    }
}