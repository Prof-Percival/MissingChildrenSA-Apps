using MCSA_API.Models.Shared;
using MCSA_API.Tests.TestUtils;
using System.Text.Json;

namespace MCSA_API.Tests.Controllers;

[TestClass]
public class EnumControllerTests
{
    private static readonly HttpClient _client = TestClientFactory.CreateClient();

    private async Task<List<EnumValueResponse>> GetEnumValuesAsync(string route)
    {
        var response = await _client.GetAsync($"/api/Enum/{route}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<EnumValueResponse>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }

    [TestMethod]
    public async Task GetGenders_ReturnsEnumValues()
    {
        var result = await GetEnumValuesAsync("genders");

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);
        CollectionAssert.AllItemsAreNotNull(result);

        Assert.IsTrue(result.Exists(x => x.Name == "Male" && x.Description == "Male"));
        Assert.IsTrue(result.Exists(x => x.Name == "Female" && x.Description == "Female"));
    }

    [TestMethod]
    public async Task GetMissingPersonStatuses_ReturnsEnumValues()
    {
        var result = await GetEnumValuesAsync("missing-person-statuses");

        Assert.IsNotNull(result);
        Assert.AreEqual(3, result.Count);
        Assert.IsTrue(result.Exists(x => x.Name == "NotFound" && x.Description == "Not Found"));
        Assert.IsTrue(result.Exists(x => x.Name == "Found" && x.Description == "Found"));
        Assert.IsTrue(result.Exists(x => x.Name == "FoundDeceased" && x.Description == "Found Deceased"));
    }

    [TestMethod]
    public async Task GetModerationStatuses_ReturnsEnumValues()
    {
        var result = await GetEnumValuesAsync("moderation-statuses");

        Assert.IsNotNull(result);
        Assert.AreEqual(4, result.Count);
        Assert.IsTrue(result.Exists(x => x.Name == "Unmoderated" && x.Description == "Unmoderated"));
    }

    [TestMethod]
    public async Task GetProvinces_ReturnsEnumValues()
    {
        var result = await GetEnumValuesAsync("provinces");

        Assert.IsNotNull(result);
        Assert.AreEqual(9, result.Count);
        Assert.IsTrue(result.Exists(x => x.Description == "Western Cape"));
    }

    [TestMethod]
    public async Task GetRaces_ReturnsEnumValues()
    {
        var result = await GetEnumValuesAsync("races");

        Assert.IsNotNull(result);
        Assert.AreEqual(6, result.Count);
        Assert.IsTrue(result.Exists(x => x.Description == "Coloured"));
    }

    [TestMethod]
    public async Task GetRoles_ReturnsEnumValues()
    {
        var result = await GetEnumValuesAsync("roles");

        Assert.IsNotNull(result);
        Assert.AreEqual(3, result.Count);
        Assert.IsTrue(result.Exists(x => x.Name == "SuperUser" && x.Description == "Super User"));
    }
}