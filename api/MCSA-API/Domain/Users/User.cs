using MCSA_API.Data.Entities;
using MCSA_API.Helpers;

namespace MCSA_API.Domain.Users;

public class User
{
    public int? Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => FormattingHelper.AsFullName(FirstName, LastName);
    public UserRole Role { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }

    public bool IsNew => !Id.HasValue;

    public User() { }

    public User(DalUser dalUser)
    {
        Id = dalUser.Id;
        Username = dalUser.Username;
        PasswordHash = dalUser.PasswordHash;
        FirstName = dalUser.FirstName;
        LastName = dalUser.LastName;
        Role = (UserRole)dalUser.RoleId;
        Created = dalUser.Created;
        Updated = dalUser.Updated;
    }
}