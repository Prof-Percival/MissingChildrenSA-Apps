namespace MissingChildrenSA.Models.Users;

public sealed class CurrentUser(CurrentUserModel userModel)
{
    public string Username { get; } = userModel.Username;
    public string FirstName { get; } = userModel.FirstName;
    public string LastName { get; } = userModel.LastName;
    public string FullName { get; } = userModel.FullName;
    public string UserRole { get; } = userModel.UserRole;
    public string Created { get; } = userModel.Created;
}