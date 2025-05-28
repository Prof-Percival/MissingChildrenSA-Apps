using MCSA_API.Data;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation.Stats;
using MCSA_API.Domain.Security;
using MCSA_API.Helpers;
using MCSA_API.Models.Moderation;
using System.Transactions;

namespace MCSA_API.Domain.Moderation;

public sealed class ModerationService(
    IMissingPersonModerationQueueRepository moderationRepository,
    IRepository<MissingPerson> missingPersonRepository,
    ICurrentUserService currentUserService) : IModerationService
{
    private static readonly HashSet<ModerationStatus> _notAllowedModerationTransitionStatuses =
    [
        ModerationStatus.InModeration,
        ModerationStatus.Unmoderated
    ];

    public async Task<ModerationQueuePagedResponse> GetModerationQueueAsync(int page, int size)
    {
        var allItems = await moderationRepository.GetAllAsync();

        var paged = allItems
            //.Where(x => x.ModerationStatus != ModerationStatus.Approved)
            .Skip(PageHelper.CalculateSkip(size, page))
            .Take(size)
            .ToList();

        return new ModerationQueuePagedResponse
        {
            Page = page,
            PageSize = size,
            TotalCount = allItems.Count(),
            Items = paged.Select(q => new ModerationQueueItemResponse(q)).ToList()
        };
    }

    public async Task<ModerationQueueItemDetailsResponse> GetQueueDetailsAsync(int queueItemId)
    {
        var queueItem = await moderationRepository.GetByIdAsync(queueItemId);

        if (queueItem == null) return null;

        var person = await missingPersonRepository.GetByIdAsync(queueItem.MissingPersonId);

        if (person == null) return null;

        return new ModerationQueueItemDetailsResponse(queueItem, person);
    }

    public async Task<string> StartModerationAsync(int queueItemId)
    {
        var userId = currentUserService.GetUserId();

        if (!userId.HasValue) return "User not logged in";

        var queueItem = await moderationRepository.GetByIdAsync(queueItemId);

        if (queueItem == null) return "Queue item not found";

        if (queueItem.ModeratedByUserId.HasValue)
        {
            return "Moderation already started";
        }

        queueItem.StartModeration(userId.Value);

        await moderationRepository.UpsertAsync(queueItem);

        return null;
    }

    public async Task<string> UpdateModerationStatusAsync(ModerationStatusUpdateRequest request)
    {
        var queueItem = await moderationRepository.GetByIdAsync(request.QueueItemId.Value);

        if (queueItem == null) return "Queue item not found";

        if (request.Status == ModerationStatus.Failed &&
            string.IsNullOrWhiteSpace(request.Reason))
        {
            return "Moderation Reason is required when failing item for moderation.";
        }

        if (_notAllowedModerationTransitionStatuses.Contains(request.Status)) return $"Cannot update moderation status to {request.Status.GetBestDescription()}";

        switch (request.Status)
        {
            case ModerationStatus.Failed:
                queueItem.FailModeration(request.Reason);
                break;
            case ModerationStatus.Approved:
                queueItem.Approve();
                break;
        }

        using var transaction = new TransactionScope();

        await moderationRepository.UpsertAsync(queueItem);

        var person = await missingPersonRepository.GetByIdAsync(queueItem.MissingPersonId);

        person.ModerationStatus = request.Status;

        await missingPersonRepository.UpsertAsync(person);

        transaction.Complete();

        return null;
    }

    public async Task<ModerationQueueStats> GetModerationQueueStats()
    {
        var items = await moderationRepository.GetAllAsync();

        return new ModerationQueueStats
        {
            Unmoderated = items.Count(i => i.ModerationStatus == ModerationStatus.Unmoderated),
            InModeration = items.Count(i => i.ModerationStatus == ModerationStatus.InModeration),
            Failed = items.Count(i => i.ModerationStatus == ModerationStatus.Failed),
            Approved = items.Count(i => i.ModerationStatus == ModerationStatus.Approved)
        };
    }
}