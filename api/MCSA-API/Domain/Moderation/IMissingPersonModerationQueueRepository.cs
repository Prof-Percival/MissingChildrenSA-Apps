using MCSA_API.Data;

namespace MCSA_API.Domain.Moderation;

public interface IMissingPersonModerationQueueRepository : IRepository<MissingPersonModerationQueue>
{
    Task<MissingPersonModerationQueue> GetByMissingPersonIdAsync(int missingPersonId);
}