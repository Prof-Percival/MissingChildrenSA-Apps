using MCSA_API.Data;
using MCSA_API.Domain;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;
using MCSA_API.Models.MissingPersons;
using Moq;

namespace MCSA_API.Tests.MissingPersons;

[TestClass]
public class MissingPersonServiceTests
{
    private Mock<IRepository<MissingPerson>> _missingPersonRepoMock;
    private Mock<IMissingPersonModerationQueueRepository> _moderationQueueRepoMock;
    private MissingPersonService _service;

    [TestInitialize]
    public void Setup()
    {
        _missingPersonRepoMock = new Mock<IRepository<MissingPerson>>();
        _moderationQueueRepoMock = new Mock<IMissingPersonModerationQueueRepository>();

        _service = new MissingPersonService(_missingPersonRepoMock.Object, _moderationQueueRepoMock.Object);
    }

    [TestMethod]
    public async Task CreateMissingPersonAsync_Should_Return_Id()
    {
        var request = new CreateMissingPersonRequest
        {
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = DateTime.UtcNow.AddYears(-30),
            Gender = Gender.Male,
            Race = Race.White,
            Province = Province.Gauteng,
            DateWentMissing = DateTime.UtcNow,
            Height = 180,
            Weight = 75
        };

        _missingPersonRepoMock.Setup(repo => repo.UpsertAsync(It.IsAny<MissingPerson>()))
            .Returns(Task.CompletedTask)
            .Callback<MissingPerson>(mp => mp.Id = 1);

        _moderationQueueRepoMock.Setup(repo => repo.UpsertAsync(It.IsAny<MissingPersonModerationQueue>()))
            .Returns(Task.CompletedTask);

        var (error, id) = await _service.CreateMissingPersonAsync(request);

        Assert.IsNull(error);
        Assert.AreEqual(1, id);
    }

    [TestMethod]
    public async Task GetMissingPersonsAsync_Should_Return_FilteredList()
    {
        List<MissingPerson> list =
        [
            new MissingPerson { ModerationStatus = ModerationStatus.Approved },
            new MissingPerson { ModerationStatus = ModerationStatus.Unmoderated }
        ];

        _missingPersonRepoMock.Setup(x => x.GetAllAsync()).ReturnsAsync(list);

        var result = await _service.GetMissingPersonsAsync(1, 10, new HashSet<ModerationStatus> { ModerationStatus.Approved });

        Assert.AreEqual(1, result.TotalCount);
    }
}