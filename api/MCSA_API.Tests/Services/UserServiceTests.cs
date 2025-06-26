using MCSA_API.Domain.Security;
using MCSA_API.Domain.Users;
using MCSA_API.Models.Users;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace MCSA_API.Tests.Services;

[TestClass]
public class UserServiceTests
{
    private Mock<IUserRepository> _userRepositoryMock;
    private Mock<IJwtHelper> _jwtHelperMock;
    private UserService _userService;

    [TestInitialize]
    public void Setup()
    {
        _userRepositoryMock = new Mock<IUserRepository>();
        _jwtHelperMock = new Mock<IJwtHelper>();
        _userService = new UserService(_userRepositoryMock.Object, _jwtHelperMock.Object);
    }

    [TestMethod]
    public async Task AuthenticateUserAsync_ValidCredentials_ReturnsToken()
    {
        var user = new User
        {
            Id = 1,
            Username = Secrets.TestUsername,
            PasswordHash = new PasswordHasher<User>().HashPassword(null, Secrets.TestPassword),
            Role = UserRole.SuperUser
        };

        _userRepositoryMock.Setup(r => r.GetByUsernameAsync(It.IsAny<string>()))
            .ReturnsAsync(user);

        _jwtHelperMock.Setup(j => j.GenerateJwtToken(user.Id.Value, user.Role))
            .Returns(Tuple.Create("token123", "SuperUser", DateTime.UtcNow.AddMinutes(10)));

        var result = await _userService.AuthenticateUserAsync(user.Username, Secrets.TestPassword);

        Assert.IsNotNull(result);
        Assert.AreEqual("token123", result.Item1);
    }

    [TestMethod]
    public async Task CreateUserAsync_DuplicateUser_ReturnsError()
    {
        var request = new CreateUserRequest
        {
            Username = "existing@mcsa.org.za",
            Password = "pass",
            FirstName = "Test",
            LastName = "User",
            UserRole = UserRole.SuperUser
        };

        _userRepositoryMock.Setup(r => r.GetByUsernameAsync(request.Username))
            .ReturnsAsync(new User { Username = request.Username });

        var result = await _userService.CreateUserAsync(request);

        Assert.IsNotNull(result.Item1);
        Assert.IsNull(result.Item2);
    }

    [TestMethod]
    public async Task UpdateUserAsync_ShouldReturnError_WhenUserNotFound()
    {
        _userRepositoryMock.Setup(r => r.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((User)null);

        var result = await _userService.UpdateUserAsync(99, new UpdateUserRequest());

        Assert.IsNotNull(result.Item1);
    }

    [TestMethod]
    public async Task GetUsersAsync_ShouldReturnPagedResult()
    {
        _userRepositoryMock.Setup(r => r.GetAllAsync()).ReturnsAsync([
            new User { Id = 1, Username = "test1" },
            new User { Id = 2, Username = "test2" }
        ]);

        var result = await _userService.GetUsersAsync(1, 1);

        Assert.AreEqual(1, result.Users.Count);
        Assert.AreEqual(2, result.TotalCount);
    }
}