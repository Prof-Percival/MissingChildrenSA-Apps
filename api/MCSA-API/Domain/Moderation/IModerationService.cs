using MCSA_API.Domain.Moderation.Stats;
using MCSA_API.Models.Moderation;

namespace MCSA_API.Domain.Moderation;

public interface IModerationService
{
    Task<ModerationQueuePagedResponse> GetModerationQueueAsync(int page, int size);
    Task<ModerationQueueItemDetailsResponse> GetQueueDetailsAsync(int queueItemId);
    Task<string> StartModerationAsync(int queueItemId);
    Task<string> UpdateModerationStatusAsync(ModerationStatusUpdateRequest request);
    Task<ModerationQueueStats> GetModerationQueueStats();
}