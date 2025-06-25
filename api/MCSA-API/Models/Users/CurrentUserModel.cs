using MCSA_API.Domain.Users;
using MCSA_API.Helpers;

namespace MCSA_API.Models.Users;

public sealed class CurrentUserModel(User user)
{
    public string Username { get; init; } = user.Username;
    public string FirstName { get; init; } = user.FirstName;
    public string LastName { get; init; } = user.LastName;
    public string FullName => FormattingHelper.AsFullName(FirstName, LastName);
    public string UserRole { get; init; } = user.Role.GetBestDescription();
    public string Created { get; init; } = FormattingHelper.FormatDateTime(user.Created);
}