using MCSA_API.Data;
using MCSA_API.Data.Repositories;
using MCSA_API.Domain;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;
using MCSA_API.Domain.Security;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace MCSA_API.Tests.MissingPersons;

[TestClass]
public class MissingPersonRepositoryTests
{
    private MissingPersonRepository _missingPersonRepository;
    private MCSAContext _context;
    private Mock<IDateProvider> _mockDate;
    private Mock<ICurrentUserService> _mockUser;
    private readonly DateTime _now = new DateTime(2025, 6, 26);

    [TestInitialize]
    public void Setup()
    {
        var opts = new DbContextOptionsBuilder<MCSAContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        _context = new MCSAContext(opts);

        _mockDate = new Mock<IDateProvider>();
        _mockDate.Setup(x => x.GetDate()).Returns(_now);

        _mockUser = new Mock<ICurrentUserService>();
        _mockUser.Setup(x => x.GetUserId()).Returns(42);

        _missingPersonRepository = new MissingPersonRepository(_context, _mockDate.Object, _mockUser.Object);
    }

    private MissingPerson CreateFullPerson(string firstName, string lastName) =>
        new MissingPerson
        {
            FirstName = firstName,
            LastName = lastName,
            DateOfBirth = new DateTime(2000, 1, 1),
            Gender = Gender.Male,
            Race = Race.African,
            Province = Province.WesternCape,
            DateWentMissing = _now.AddDays(-3),
            HairColour = "Black",
            HairLengthOrStyle = "Short",
            EyeColour = "Brown",
            Height = 170,
            Weight = 70,
            MarksTattoos = "None",
            LastSeenWearing = "Blue shirt",
            LocationLastSeen = "Cape Town",
            DetailsOfDisappearance = "Details",
            ImageUrl = "http://example.com/img.jpg",
            PoliceStation = "Cape Town Station",
            CaseNumber = "CASE123",
            InvestigatingOfficer = "Officer Test",
            InvestigatingOfficerContactNumber = "0123456789",
            FamilyContactName = "Parent Test",
            FamilyContactNumber = "0987654321",
            Status = MissingPersonStatus.NotFound,
            ModerationStatus = ModerationStatus.Unmoderated
        };

    [TestMethod]
    public async Task UpsertAsync_CreatesNewMissingPerson_SetsAllPropertiesIncludingUser()
    {
        var person = CreateFullPerson("Jane", "Doe");

        await _missingPersonRepository.UpsertAsync(person);

        Assert.IsTrue(person.Id.HasValue && person.Id.Value > 0);

        var saved = await _missingPersonRepository.GetByIdAsync(person.Id.Value);

        Assert.IsNotNull(saved);
        Assert.AreEqual("Jane", saved.FirstName);
        Assert.AreEqual(42, saved.LastEditedByUserId); // current user
        Assert.AreEqual(_now, saved.Created);
        Assert.AreEqual(_now, saved.Updated);
        Assert.AreEqual(ModerationStatus.Unmoderated, saved.ModerationStatus);
    }

    [TestMethod]
    public async Task GetByIdAsync_ReturnsCorrectMissingPerson_WhenExists()
    {
        var person = CreateFullPerson("Alice", "Smith");
        await _missingPersonRepository.UpsertAsync(person);

        var fetched = await _missingPersonRepository.GetByIdAsync(person.Id.Value);

        Assert.IsNotNull(fetched);
        Assert.AreEqual("Alice", fetched.FirstName);
        Assert.AreEqual("Smith", fetched.LastName);
    }

    [TestMethod]
    public async Task GetByIdAsync_ReturnsNull_WhenNotFound()
    {
        var result = await _missingPersonRepository.GetByIdAsync(9999);

        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task GetAllAsync_ReturnsAllMissingPersons()
    {
        await _missingPersonRepository.UpsertAsync(CreateFullPerson("Bob", "Jones"));
        await _missingPersonRepository.UpsertAsync(CreateFullPerson("Carol", "White"));

        var all = (await _missingPersonRepository.GetAllAsync()).Select(x => x.FirstName).ToList();

        CollectionAssert.AreEquivalent(new[] { "Bob", "Carol" }, all);
    }

    [TestMethod]
    public async Task DeleteAsync_RemovesEntity_WhenExists()
    {
        var person = CreateFullPerson("DeleteMe", "User");

        await _missingPersonRepository.UpsertAsync(person);

        await _missingPersonRepository.DeleteAsync(person.Id.Value);

        var found = await _missingPersonRepository.GetByIdAsync(person.Id.Value);

        Assert.IsNull(found);
    }

    [TestMethod]
    public async Task DeleteAsync_DoesNothing_WhenEntityNotFound()
    {
        await _missingPersonRepository.DeleteAsync(123456); // no exception expected
    }
}