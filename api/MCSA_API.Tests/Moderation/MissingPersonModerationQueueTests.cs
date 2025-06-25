using MCSA_API.Domain.Moderation;

namespace MCSA_API.Tests.Moderation;

[TestClass]
public class MissingPersonModerationQueueTests
{
    [TestMethod]
    public void TryStartModeration_SetsStatusAndUserId_WhenNotStarted()
    {
        var queue = new MissingPersonModerationQueue();
        queue.SetUnmoderated();

        var result = queue.TryStartModeration(123, out var error);

        Assert.IsTrue(result);
        Assert.IsNull(error);
        Assert.AreEqual(ModerationStatus.InModeration, queue.ModerationStatus);
        Assert.AreEqual(123, queue.ModeratedByUserId);
    }

    [TestMethod]
    public void TryStartModeration_Fails_WhenAlreadyStarted()
    {
        var queue = new MissingPersonModerationQueue();
        queue.TryStartModeration(1, out _);

        var result = queue.TryStartModeration(2, out var error);

        Assert.IsFalse(result);
        Assert.AreEqual("Moderation already started", error);
        Assert.AreEqual(1, queue.ModeratedByUserId);
    }

    [TestMethod]
    public void TryFailModeration_SetsStatusAndReason_WhenValidReason()
    {
        var queue = new MissingPersonModerationQueue();
        queue.SetUnmoderated();

        var result = queue.TryFailModeration("Bad data", out var error);

        Assert.IsTrue(result);
        Assert.IsNull(error);
        Assert.AreEqual(ModerationStatus.Failed, queue.ModerationStatus);
        Assert.AreEqual("Bad data", queue.ModerationStatusReason);
    }

    [TestMethod]
    public void TryFailModeration_Fails_WhenEmptyReason()
    {
        var queue = new MissingPersonModerationQueue();

        var result = queue.TryFailModeration("", out var error);

        Assert.IsFalse(result);
        Assert.AreEqual("Moderation Reason is required when failing item for moderation.", error);
    }

    [TestMethod]
    public void Approve_SetsStatusToApproved()
    {
        var queue = new MissingPersonModerationQueue();
        queue.Approve();

        Assert.AreEqual(ModerationStatus.Approved, queue.ModerationStatus);
    }
}