using MCSA_API.Data.Entities;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Security;
using Microsoft.EntityFrameworkCore;

namespace MCSA_API.Data.Repositories;

public class MissingPersonRepository(
    MCSAContext context,
    IDateProvider dateProvider,
    ICurrentUserService currentUserService) : IRepository<MissingPerson>
{
    public async Task<MissingPerson> GetByIdAsync(int id)
    {
        var dalMissingPerson = await context.MissingPerson.FindAsync(id);

        if (dalMissingPerson == null)
        {
            return null;
        }

        return new MissingPerson(dalMissingPerson);
    }

    public async Task<IEnumerable<MissingPerson>> GetAllAsync()
    {
        var users = await context.MissingPerson.ToListAsync();

        return users.ConvertAll(x => new MissingPerson(x));
    }

    public async Task UpsertAsync(MissingPerson entity)
    {
        var now = dateProvider.GetDate();

        DalMissingPerson dalMissingPerson;

        if (entity.IsNew)
        {
            dalMissingPerson = new DalMissingPerson
            {
                Created = now
            };
        }
        else
        {
            dalMissingPerson = await context.MissingPerson.FindAsync(entity.Id.Value);
        }

        dalMissingPerson.FirstName = entity.FirstName;
        dalMissingPerson.LastName = entity.LastName;
        dalMissingPerson.DateOfBirth = entity.DateOfBirth;
        dalMissingPerson.GenderId = (int)entity.Gender;
        dalMissingPerson.RaceId = (int)entity.Race;
        dalMissingPerson.ProvinceId = (int)entity.Province;
        dalMissingPerson.DateWentMissing = entity.DateWentMissing;
        dalMissingPerson.HairColour = entity.HairColour;
        dalMissingPerson.HairLengthOrStyle = entity.HairLengthOrStyle;
        dalMissingPerson.EyeColour = entity.EyeColour;
        dalMissingPerson.Height = entity.Height;
        dalMissingPerson.Weight = entity.Weight;
        dalMissingPerson.MarksTattoos = entity.MarksTattoos;
        dalMissingPerson.LastSeenWearing = entity.LastSeenWearing;
        dalMissingPerson.LocationLastSeen = entity.LocationLastSeen;
        dalMissingPerson.DetailsOfDisappearance = entity.DetailsOfDisappearance;
        dalMissingPerson.ImageUrl = entity.ImageUrl;
        dalMissingPerson.PoliceStation = entity.PoliceStation;
        dalMissingPerson.CaseNumber = entity.CaseNumber;
        dalMissingPerson.InvestigatingOfficer = entity.InvestigatingOfficer;
        dalMissingPerson.InvestigatingOfficerContactNumber = entity.InvestigatingOfficerContactNumber;
        dalMissingPerson.FamilyContactName = entity.FamilyContactName;
        dalMissingPerson.FamilyContactNumber = entity.FamilyContactNumber;
        dalMissingPerson.StatusId = (int)entity.Status;
        dalMissingPerson.Updated = now;
        dalMissingPerson.ModerationStatusId = (int)entity.ModerationStatus;
        dalMissingPerson.LastEditedByUserId = currentUserService.GetUserId();

        context.MissingPerson.Update(dalMissingPerson);

        await context.SaveChangesAsync();

        entity.Id = dalMissingPerson.Id;
    }

    public async Task DeleteAsync(int id)
    {
        var dalMissingPerson = await context.MissingPerson.FindAsync(id);

        if (dalMissingPerson != null)
        {
            context.MissingPerson.Remove(dalMissingPerson);

            await context.SaveChangesAsync();
        }
    }
}