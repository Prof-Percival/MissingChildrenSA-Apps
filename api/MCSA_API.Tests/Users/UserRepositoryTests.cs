using MCSA_API.Data;
using MCSA_API.Data.Repositories;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace MCSA_API.Tests.Users;

[TestClass]
public class UserRepositoryTests
{
    private UserRepository _userRepository;
    private MCSAContext _context;

    [TestInitialize]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<MCSAContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new MCSAContext(options);

        var dateProvider = new DateProvider();

        _userRepository = new UserRepository(_context, dateProvider);
    }

    [TestMethod]
    public async Task UpsertAsync_CreatesNewUser()
    {
        var user = new User
        {
            Username = "upsertuser@test.com",
            FirstName = "Up",
            LastName = "Sert",
            PasswordHash = "hashed",
            Role = UserRole.SuperUser
        };

        await _userRepository.UpsertAsync(user);

        Assert.IsTrue(user.Id.HasValue);

        var fetched = await _userRepository.GetByIdAsync(user.Id.Value);

        Assert.AreEqual("upsertuser@test.com", fetched.Username);
    }
}