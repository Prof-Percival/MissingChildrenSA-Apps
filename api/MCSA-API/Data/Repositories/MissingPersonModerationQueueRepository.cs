using MCSA_API.Data.Entities;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.Moderation;
using Microsoft.EntityFrameworkCore;

namespace MCSA_API.Data.Repositories;

public class MissingPersonModerationQueueRepository(
    MCSAContext context,
    IDateProvider dateProvider) : IRepository<MissingPersonModerationQueue>
{
    public async Task<MissingPersonModerationQueue> GetByIdAsync(int id)
    {
        var dalMissingPerson = await context.MissingPersonModerationQueue.FindAsync(id);

        if (dalMissingPerson == null)
        {
            return null;
        }

        return new MissingPersonModerationQueue(dalMissingPerson);
    }

    public async Task<IEnumerable<MissingPersonModerationQueue>> GetAllAsync()
    {
        var users = await context.MissingPersonModerationQueue.ToListAsync();

        return users.ConvertAll(x => new MissingPersonModerationQueue(x));
    }

    public async Task UpsertAsync(MissingPersonModerationQueue entity)
    {
        var now = dateProvider.GetDate();

        DalMissingPersonModerationQueue dalMissingPersonModerationQueue;

        if (entity.IsNew)
        {
            dalMissingPersonModerationQueue = new DalMissingPersonModerationQueue
            {
                Created = now,
                MissingPersonId = entity.MissingPersonId
            };
        }
        else
        {
            dalMissingPersonModerationQueue = await context.MissingPersonModerationQueue.FindAsync(entity.Id.Value);
        }

        dalMissingPersonModerationQueue.ModeratedByUserId = entity.ModeratedByUserId;
        dalMissingPersonModerationQueue.ModerationStatusId = (int)entity.ModerationStatus;
        dalMissingPersonModerationQueue.ModerationStatusReason = entity.ModerationStatusReason;
        dalMissingPersonModerationQueue.Updated = now;

        context.MissingPersonModerationQueue.Update(dalMissingPersonModerationQueue);

        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var dalMissingPersonModerationQueue = await context.MissingPersonModerationQueue.FindAsync(id);

        if (dalMissingPersonModerationQueue != null)
        {
            context.MissingPersonModerationQueue.Remove(dalMissingPersonModerationQueue);

            await context.SaveChangesAsync();
        }
    }
}