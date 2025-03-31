using MCSA_API.Domain.Users;
using MCSA_API.Helpers;

namespace MCSA_API.Models.Users;

public sealed class GetUserResponse
{
    public int Id { get; init; }
    public string Username { get; init; }
    public string FirstName { get; init; }
    public string FullName => FormattingHelper.AsFullName(FirstName, LastName);
    public string LastName { get; init; }
    public string UserRole { get; init; }
    public string Created { get; init; }
    public string Updated { get; init; }

    public GetUserResponse() { }

    public GetUserResponse(User user)
    {
        Id = user.Id.Value;
        Username = user.Username;
        FirstName = user.FirstName;
        LastName = user.LastName;
        UserRole = user.Role.GetBestDescription();
        Created = FormattingHelper.FormatDateTime(user.Created);
        Updated = FormattingHelper.FormatDateTime(user.Updated);
    }
}