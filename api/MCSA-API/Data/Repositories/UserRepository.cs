using MCSA_API.Data.Entities;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace MCSA_API.Data.Repositories;

public class UserRepository(
    MCSAContext context,
    IDateProvider dateProvider) : IUserRepository
{
    public async Task<User> GetByUsernameAsync(string username)
    {
        var dalUser = await context.User.SingleOrDefaultAsync(u => u.Username == username);

        if (dalUser == null)
        {
            return null;
        }

        return new User(dalUser);
    }

    public async Task<User> GetByIdAsync(int id)
    {
        var dalUser = await context.User.FindAsync(id);

        if (dalUser == null)
        {
            return null;
        }

        return new User(dalUser);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        var users = await context.User.ToListAsync();

        return users.ConvertAll(x => new User(x));
    }

    public async Task UpsertAsync(User entity)
    {
        var now = dateProvider.GetDate();

        DalUser dalUser;

        if (entity.IsNew)
        {
            dalUser = new DalUser
            {
                Username = entity.Username,
                Created = now
            };
        }
        else
        {
            dalUser = await context.User.FindAsync(entity.Id.Value);
        }

        dalUser.FirstName = entity.FirstName;
        dalUser.LastName = entity.LastName;
        dalUser.PasswordHash = entity.PasswordHash;
        dalUser.RoleId = (int)entity.Role;
        dalUser.Updated = now;

        context.User.Update(dalUser);

        await context.SaveChangesAsync();

        entity.Id = dalUser.Id;
        entity.Created = dalUser.Created;
        entity.Updated = dalUser.Updated;
        entity.Role = (UserRole)dalUser.RoleId;
    }

    public async Task DeleteAsync(int id)
    {
        var dalUser = await context.User.FindAsync(id);

        if (dalUser != null)
        {
            context.User.Remove(dalUser);

            await context.SaveChangesAsync();
        }
    }
}