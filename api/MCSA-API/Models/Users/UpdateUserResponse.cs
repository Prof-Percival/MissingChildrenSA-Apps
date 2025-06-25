using MCSA_API.Models.Shared;

namespace MCSA_API.Models.Users;

public class UpdateUserResponse : Person
{
    public int Id { get; init; }
    public string Username { get; init; }
    public string UserRole { get; init; }
    public string Created { get; init; }
    public string Updated { get; init; }
}