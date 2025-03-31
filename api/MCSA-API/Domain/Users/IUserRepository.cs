using MCSA_API.Data;

namespace MCSA_API.Domain.Users;

public interface IUserRepository : IRepository<User>
{
    Task<User> GetByUsernameAsync(string username);
}