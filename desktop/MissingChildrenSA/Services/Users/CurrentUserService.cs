using MissingChildrenSA.Models.Users;

namespace MissingChildrenSA.Services.Users;

public sealed class CurrentUserService(
    ApiClient apiClient)
{
    public async Task<CurrentUser> GetCurrentUser()
    {
        var response = await apiClient.MeAsync();

        return new CurrentUser(response);
    }
}