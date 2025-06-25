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
        Assert.AreEqual(UserRole.SuperUser, fetched.Role);
    }

    [TestMethod]
    public async Task GetByUsernameAsync_ReturnsCorrectUser()
    {
        var user = new User
        {
            Username = "userbyname@test.com",
            FirstName = "Name",
            LastName = "Lookup",
            PasswordHash = "pass",
            Role = UserRole.Receptionist
        };

        await _userRepository.UpsertAsync(user);

        var fetched = await _userRepository.GetByUsernameAsync("userbyname@test.com");

        Assert.IsNotNull(fetched);
        Assert.AreEqual(user.Username, fetched.Username);
    }

    [TestMethod]
    public async Task UpsertAsync_UpdatesExistingUser()
    {
        var user = new User
        {
            Username = "updateuser@test.com",
            FirstName = "Initial",
            LastName = "User",
            PasswordHash = "oldhash",
            Role = UserRole.Receptionist
        };

        await _userRepository.UpsertAsync(user);
        var originalUpdated = user.Updated;

        // Modify
        user.FirstName = "Updated";
        user.PasswordHash = "newhash";
        user.Role = UserRole.OperationalSupport;

        await _userRepository.UpsertAsync(user);

        var fetched = await _userRepository.GetByIdAsync(user.Id.Value);

        Assert.AreEqual("Updated", fetched.FirstName);
        Assert.AreEqual(UserRole.OperationalSupport, fetched.Role);
        Assert.IsTrue(fetched.Updated > originalUpdated);
    }

    [TestMethod]
    public async Task GetAllAsync_ReturnsAllUsers()
    {
        var user1 = new User { Username = "a@test.com", FirstName = "A", LastName = "Test", PasswordHash = "hash", Role = UserRole.SuperUser };
        var user2 = new User { Username = "b@test.com", FirstName = "B", LastName = "Test", PasswordHash = "hash", Role = UserRole.Receptionist };

        await _userRepository.UpsertAsync(user1);
        await _userRepository.UpsertAsync(user2);

        var users = (await _userRepository.GetAllAsync()).ToList();

        Assert.AreEqual(2, users.Count);
        Assert.IsTrue(users.Any(u => u.Username == "a@test.com"));
        Assert.IsTrue(users.Any(u => u.Username == "b@test.com"));
    }

    [TestMethod]
    public async Task DeleteAsync_RemovesUser()
    {
        var user = new User
        {
            Username = "deleteuser@test.com",
            FirstName = "Delete",
            LastName = "Me",
            PasswordHash = "hash",
            Role = UserRole.SuperUser
        };

        await _userRepository.UpsertAsync(user);

        Assert.IsNotNull(await _userRepository.GetByIdAsync(user.Id.Value));

        await _userRepository.DeleteAsync(user.Id.Value);

        var deleted = await _userRepository.GetByIdAsync(user.Id.Value);
        Assert.IsNull(deleted);
    }
}