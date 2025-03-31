using MCSA_API.Helpers;
using MCSA_API.Models.Shared;

namespace MCSA_API.Models.Users;

public sealed class CreateUserResponse : Person
{
    public int Id { get; set; }
    public string Username { get; init; }
    public string UserRole { get; init; }
    public string FullName => FormattingHelper.AsFullName(FirstName, LastName);
    public string Created { get; init; }
}