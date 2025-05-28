using MCSA_API.Data;
using MCSA_API.Domain.Moderation;
using MCSA_API.Extensions;
using MCSA_API.Helpers;
using MCSA_API.Models.MissingPersons;
using System.Transactions;

namespace MCSA_API.Domain.MissingPersons;

public sealed class MissingPersonService(
    IRepository<MissingPerson> missingPersonRepository,
    IMissingPersonModerationQueueRepository moderationQueueRepository) : IMissingPersonService
{
    public async Task<(string, int)> CreateMissingPersonAsync(CreateMissingPersonRequest request)
    {
        var missingPerson = new MissingPerson
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            DateOfBirth = request.DateOfBirth.Value.ToSouthAfricanTime().Date,
            Gender = request.Gender.Value,
            Race = request.Race.Value,
            Province = request.Province.Value,
            DateWentMissing = request.DateWentMissing.Value.ToSouthAfricanTime(),
            HairColour = request.HairColour,
            HairLengthOrStyle = request.HairLengthOrStyle,
            EyeColour = request.EyeColour,
            Height = request.Height.Value,
            Weight = request.Weight.Value,
            MarksTattoos = request.MarksTattoos,
            LastSeenWearing = request.LastSeenWearing,
            LocationLastSeen = request.LocationLastSeen,
            ImageUrl = request.ImageUrl,
            PoliceStation = request.PoliceStation,
            CaseNumber = request.CaseNumber,
            InvestigatingOfficer = request.InvestigatingOfficer,
            InvestigatingOfficerContactNumber = request.InvestigatingOfficerContactNumber,
            FamilyContactName = request.FamilyContactName,
            FamilyContactNumber = request.FamilyContactNumber,
            Status = MissingPersonStatus.NotFound,
            ModerationStatus = ModerationStatus.Unmoderated
        };

        using var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

        await missingPersonRepository.UpsertAsync(missingPerson);

        var queueItem = new MissingPersonModerationQueue
        {
            MissingPersonId = missingPerson.Id.Value,
            ModerationStatus = ModerationStatus.Unmoderated
        };

        await moderationQueueRepository.UpsertAsync(queueItem);

        transaction.Complete();

        return (null, missingPerson.Id.Value);
    }

    public async Task<string> UpdateMissingPersonAsync(UpdateMissingPersonRequest request)
    {
        var existing = await missingPersonRepository.GetByIdAsync(request.Id.Value);

        if (existing == null) return "Missing person not found";

        existing.FirstName = request.FirstName;
        existing.LastName = request.LastName;
        existing.DateOfBirth = request.DateOfBirth.Value.ToSouthAfricanTime().Date;
        existing.Gender = request.Gender.Value;
        existing.Race = request.Race.Value;
        existing.Province = request.Province.Value;
        existing.DateWentMissing = request.DateWentMissing.Value.ToSouthAfricanTime();
        existing.HairColour = request.HairColour;
        existing.HairLengthOrStyle = request.HairLengthOrStyle;
        existing.EyeColour = request.EyeColour;
        existing.Height = request.Height.Value;
        existing.Weight = request.Weight.Value;
        existing.MarksTattoos = request.MarksTattoos;
        existing.LastSeenWearing = request.LastSeenWearing;
        existing.LocationLastSeen = request.LocationLastSeen;
        existing.ImageUrl = request.ImageUrl;
        existing.PoliceStation = request.PoliceStation;
        existing.CaseNumber = request.CaseNumber;
        existing.InvestigatingOfficer = request.InvestigatingOfficer;
        existing.InvestigatingOfficerContactNumber = request.InvestigatingOfficerContactNumber;
        existing.FamilyContactName = request.FamilyContactName;
        existing.FamilyContactNumber = request.FamilyContactNumber;
        existing.Status = request.Status.Value;
        existing.ModerationStatus = ModerationStatus.Unmoderated;

        var queueItem = await moderationQueueRepository.GetByMissingPersonIdAsync(existing.Id.Value);

        queueItem.ModerationStatus = existing.ModerationStatus;
        queueItem.ModeratedByUserId = null;

        using var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

        await missingPersonRepository.UpsertAsync(existing);

        await moderationQueueRepository.UpsertAsync(queueItem);

        transaction.Complete();

        existing = await GetMissingPersonByIdAsync(existing.Id.Value);

        return null;
    }

    public async Task<PagedMissingPersonsResult> GetMissingPersonsAsync(int pageNumber, int pageSize)
    {
        var allMissingPersons = await missingPersonRepository.GetAllAsync();

        var totalCount = allMissingPersons.Count();

        var missingPersons = allMissingPersons
            .Skip(PageHelper.CalculateSkip(pageSize, pageNumber))
            .Take(pageSize)
            .ToList();

        return new PagedMissingPersonsResult
        {
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize,
            MissingPersons = missingPersons
        };
    }

    public async Task<MissingPerson> GetMissingPersonByIdAsync(int id) => await missingPersonRepository.GetByIdAsync(id);
}