namespace MCSA_API.Tests.TestUtils;

public static class TestClientFactory
{
    public static HttpClient CreateClient()
    {
        return new HttpClient
        {
            BaseAddress = new Uri("https://mcsa-backend.azurewebsites.net")
        };
    }
}