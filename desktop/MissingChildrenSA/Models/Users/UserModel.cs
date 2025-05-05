namespace MissingChildrenSA.Models.Users;

public sealed class UserModel(GetUserResponse user)
{
    public int Id { get; } = user.Id;
    public string Username { get; } = user.Username;
    public string FirstName { get; } = user.FirstName;
    public string LastName { get; } = user.LastName;
    public string FullName { get; } = user.FullName;
    public string UserRole { get; } = user.UserRole;
    public string Created { get; } = user.Created;
    public string Updated { get; } = user.Updated;
}