namespace MCSA_API.Domain.Users;

public class User
{
    public int? Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserRole Role { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }

    public bool IsNew => !Id.HasValue;
}