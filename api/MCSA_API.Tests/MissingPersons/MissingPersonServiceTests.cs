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
    private Mock<IRepository<MissingPerson>> _missingPersonRepositoryMock;
    private Mock<IMissingPersonModerationQueueRepository> _moderationQueueRepositoryMock;
    private MissingPersonService _service;

    [TestInitialize]
    public void Setup()
    {
        _missingPersonRepositoryMock = new Mock<IRepository<MissingPerson>>();
        _moderationQueueRepositoryMock = new Mock<IMissingPersonModerationQueueRepository>();

        _service = new MissingPersonService(_missingPersonRepositoryMock.Object, _moderationQueueRepositoryMock.Object);
    }

    [TestMethod]
    public async Task CreateMissingPersonAsync_CreatesPersonAndModerationQueue()
    {
        // Arrange
        var request = new CreateMissingPersonRequest
        {
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = DateTime.UtcNow.AddYears(-30),
            Gender = Gender.Male,
            Race = Race.African,
            Province = Province.EasternCape,
            DateWentMissing = DateTime.UtcNow,
            Height = 180,
            Weight = 75
        };

        MissingPerson capturedMissingPerson = null;
        MissingPersonModerationQueue capturedQueueItem = null;

        _missingPersonRepositoryMock
            .Setup(x => x.UpsertAsync(It.IsAny<MissingPerson>()))
            .Returns(Task.CompletedTask)
            .Callback<MissingPerson>(mp =>
            {
                mp.Id = 123; // Simulate assigned ID from DB
                capturedMissingPerson = mp;
            });

        _moderationQueueRepositoryMock
            .Setup(x => x.UpsertAsync(It.IsAny<MissingPersonModerationQueue>()))
            .Returns(Task.CompletedTask)
            .Callback<MissingPersonModerationQueue>(mq => capturedQueueItem = mq);

        // Act
        var (error, id) = await _service.CreateMissingPersonAsync(request);

        // Assert
        Assert.IsNull(error);
        Assert.IsNotNull(capturedMissingPerson);
        Assert.IsTrue(capturedMissingPerson.Id.HasValue);
        Assert.AreEqual(capturedMissingPerson.Id.Value, id);
        Assert.IsNotNull(capturedQueueItem);
        Assert.AreEqual(capturedQueueItem.MissingPersonId, capturedMissingPerson.Id.Value);
        Assert.AreEqual(ModerationStatus.Unmoderated, capturedQueueItem.ModerationStatus);
    }

    [TestMethod]
    public async Task UpdateMissingPersonAsync_ReturnsError_WhenPersonNotFound()
    {
        var updateRequest = new UpdateMissingPersonRequest { Id = 123 };

        _missingPersonRepositoryMock.Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((MissingPerson)null);

        var error = await _service.UpdateMissingPersonAsync(updateRequest);

        Assert.AreEqual("Missing person not found", error);
    }

    [TestMethod]
    public async Task UpdateMissingPersonAsync_UpdatesPersonAndQueue()
    {
        var existingPerson = new MissingPerson
        {
            Id = 123,
            ModerationStatus = ModerationStatus.Approved,
            Status = MissingPersonStatus.NotFound
        };

        var updateRequest = new UpdateMissingPersonRequest
        {
            Id = 123,
            FirstName = "Jane",
            LastName = "Smith",
            DateOfBirth = DateTime.UtcNow.AddYears(-25),
            Gender = Gender.Male,
            Race = Race.African,
            Province = Province.EasternCape,
            DateWentMissing = DateTime.UtcNow,
            Height = 165,
            Weight = 60,
            Status = MissingPersonStatus.Found
        };

        var moderationQueue = new MissingPersonModerationQueue
        {
            MissingPersonId = 123
        };

        moderationQueue.Approve();

        _missingPersonRepositoryMock.Setup(x => x.GetByIdAsync(123)).ReturnsAsync(existingPerson);
        _moderationQueueRepositoryMock.Setup(x => x.GetByMissingPersonIdAsync(123)).ReturnsAsync(moderationQueue);
        _missingPersonRepositoryMock.Setup(x => x.UpsertAsync(existingPerson)).Returns(Task.CompletedTask);
        _moderationQueueRepositoryMock.Setup(x => x.UpsertAsync(moderationQueue)).Returns(Task.CompletedTask);

        var error = await _service.UpdateMissingPersonAsync(updateRequest);

        Assert.IsNull(error);
        Assert.AreEqual("Jane", existingPerson.FirstName);
        Assert.AreEqual(MissingPersonStatus.Found, existingPerson.Status);
        Assert.AreEqual(ModerationStatus.Unmoderated, existingPerson.ModerationStatus);
        Assert.AreEqual(ModerationStatus.Unmoderated, moderationQueue.ModerationStatus);
    }

    [TestMethod]
    public async Task GetMissingPersonsAsync_FiltersAndPaginates()
    {
        var allPersons = new List<MissingPerson>
        {
            new MissingPerson { Id = 1, ModerationStatus = ModerationStatus.Unmoderated },
            new MissingPerson { Id = 2, ModerationStatus = ModerationStatus.Approved },
            new MissingPerson { Id = 3, ModerationStatus = ModerationStatus.Failed },
            new MissingPerson { Id = 4, ModerationStatus = ModerationStatus.Unmoderated }
        };

        _missingPersonRepositoryMock.Setup(x => x.GetAllAsync()).ReturnsAsync(allPersons);

        var statuses = new HashSet<ModerationStatus> { ModerationStatus.Unmoderated };

        var result = await _service.GetMissingPersonsAsync(1, 2, statuses);

        Assert.AreEqual(2, result.MissingPersons.Count);
        Assert.IsTrue(result.MissingPersons.All(p => statuses.Contains(p.ModerationStatus)));
        Assert.AreEqual(2, result.PageSize);
        Assert.AreEqual(1, result.PageNumber);
        Assert.AreEqual(2, result.TotalCount);
    }

    [TestMethod]
    public async Task GetMissingPersonByIdAsync_ReturnsPerson()
    {
        var person = new MissingPerson { Id = 1 };

        _missingPersonRepositoryMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(person);

        var result = await _service.GetMissingPersonByIdAsync(1);

        Assert.AreEqual(person, result);
    }
}