using MCSA_API.Tests.TestUtils;
using System.Net.Http.Json;

namespace MCSA_API.Tests.AuthTests;

[TestClass]
public class AuthControllerTests
{
    private HttpClient _client;

    [TestInitialize]
    public void Setup()
    {
        _client = TestClientFactory.CreateClient();
    }

    [TestMethod]
    public async Task Authenticate_WithValidCredentials_ReturnsToken()
    {
        var payload = new
        {
            username = Secrets.TestUsername,
            password = Secrets.TestPassword
        };

        var response = await _client.PostAsJsonAsync("/api/Auth/authenticate", payload);

        Assert.IsTrue(response.IsSuccessStatusCode, "Expected 200 OK");

        var result = await response.Content.ReadFromJsonAsync<AuthenticateResponse>();

        Assert.IsFalse(string.IsNullOrWhiteSpace(result.Token), "Token should not be null or empty");
        Assert.AreEqual("SuperUser", result.Role);
    }

    [TestMethod]
    public async Task Authenticate_WithInvalidPassword_ReturnsUnauthorized()
    {
        var payload = new
        {
            username = Secrets.TestUsername,
            password = "WrongPassword"
        };

        var response = await _client.PostAsJsonAsync("/api/Auth/authenticate", payload);

        Assert.AreEqual(System.Net.HttpStatusCode.Unauthorized, response.StatusCode);
    }

    private class AuthenticateResponse
    {
        public string Token { get; set; }
        public string Role { get; set; }
        public DateTime TokenExpiry { get; set; }
    }
}
