using MCSA_API.Data;
using MCSA_API.Data.Repositories;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.Moderation;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace MCSA_API.Tests.Moderation;

[TestClass]
public class MissingPersonModerationQueueRepositoryTests
{
    private MissingPersonModerationQueueRepository _moderationQueueRepository;
    private MCSAContext _context;
    private Mock<IDateProvider> _mockDateProvider;

    private readonly DateTime _now = new DateTime(2025, 6, 26);

    [TestInitialize]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<MCSAContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        _context = new MCSAContext(options);

        _mockDateProvider = new Mock<IDateProvider>();
        _mockDateProvider.Setup(m => m.GetDate()).Returns(_now);

        _moderationQueueRepository = new MissingPersonModerationQueueRepository(_context, _mockDateProvider.Object);
    }

    [TestMethod]
    public async Task UpsertAsync_CreatesNewQueueItem()
    {
        var queue = new MissingPersonModerationQueue
        {
            MissingPersonId = 123
        };
        queue.SetUnmoderated();

        await _moderationQueueRepository.UpsertAsync(queue);

        Assert.IsTrue(queue.Id.HasValue && queue.Id > 0);

        var saved = await _context.MissingPersonModerationQueue.FindAsync(queue.Id.Value);

        Assert.IsNotNull(saved);
        Assert.AreEqual(123, saved.MissingPersonId);
        Assert.AreEqual(_now, saved.Created);
        Assert.AreEqual(_now, saved.Updated);
        Assert.AreEqual((int)queue.ModerationStatus, saved.ModerationStatusId);
    }

    [TestMethod]
    public async Task UpsertAsync_UpdatesExistingQueueItem()
    {
        var dal = new Data.Entities.DalMissingPersonModerationQueue
        {
            Created = _now.AddDays(-1),
            Updated = _now.AddDays(-1),
            MissingPersonId = 222,
            ModerationStatusId = (int)ModerationStatus.Unmoderated
        };
        _context.MissingPersonModerationQueue.Add(dal);
        await _context.SaveChangesAsync();

        var queue = new MissingPersonModerationQueue(dal);

        queue.TryStartModeration(5, out _);

        await _moderationQueueRepository.UpsertAsync(queue);

        var updated = await _context.MissingPersonModerationQueue.FindAsync(queue.Id.Value);

        Assert.IsNotNull(updated);
        Assert.AreEqual(222, updated.MissingPersonId);
        Assert.AreEqual(_now, updated.Updated);
        Assert.AreEqual((int)ModerationStatus.InModeration, updated.ModerationStatusId);
        Assert.AreEqual(5, updated.ModeratedByUserId);
    }

    [TestMethod]
    public async Task GetByIdAsync_ReturnsQueueItem_WhenExists()
    {
        var dal = new Data.Entities.DalMissingPersonModerationQueue
        {
            Created = _now,
            Updated = _now,
            MissingPersonId = 333,
            ModerationStatusId = (int)ModerationStatus.Unmoderated
        };
        _context.MissingPersonModerationQueue.Add(dal);
        await _context.SaveChangesAsync();

        var queue = await _moderationQueueRepository.GetByIdAsync(dal.Id);

        Assert.IsNotNull(queue);
        Assert.AreEqual(dal.Id, queue.Id);
        Assert.AreEqual(333, queue.MissingPersonId);
    }

    [TestMethod]
    public async Task GetByIdAsync_ReturnsNull_WhenNotFound()
    {
        var queue = await _moderationQueueRepository.GetByIdAsync(999999);
        Assert.IsNull(queue);
    }

    [TestMethod]
    public async Task GetAllAsync_ReturnsAllItems()
    {
        _context.MissingPersonModerationQueue.Add(new Data.Entities.DalMissingPersonModerationQueue
        {
            Created = _now,
            Updated = _now,
            MissingPersonId = 1,
            ModerationStatusId = (int)ModerationStatus.Unmoderated
        });
        _context.MissingPersonModerationQueue.Add(new Data.Entities.DalMissingPersonModerationQueue
        {
            Created = _now,
            Updated = _now,
            MissingPersonId = 2,
            ModerationStatusId = (int)ModerationStatus.Approved
        });
        await _context.SaveChangesAsync();

        var all = (await _moderationQueueRepository.GetAllAsync()).ToList();

        Assert.AreEqual(2, all.Count);
        CollectionAssert.AreEquivalent(new[] { 1, 2 }, all.Select(q => q.MissingPersonId).ToArray());
    }

    [TestMethod]
    public async Task DeleteAsync_RemovesEntity_WhenExists()
    {
        var dal = new Data.Entities.DalMissingPersonModerationQueue
        {
            Created = _now,
            Updated = _now,
            MissingPersonId = 99,
            ModerationStatusId = (int)ModerationStatus.Unmoderated
        };
        _context.MissingPersonModerationQueue.Add(dal);
        await _context.SaveChangesAsync();

        await _moderationQueueRepository.DeleteAsync(dal.Id);

        var deleted = await _context.MissingPersonModerationQueue.FindAsync(dal.Id);
        Assert.IsNull(deleted);
    }

    [TestMethod]
    public async Task DeleteAsync_DoesNothing_WhenNotExists()
    {
        await _moderationQueueRepository.DeleteAsync(999999);
        // No exception expected
    }
}