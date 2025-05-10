using MCSA_API.Models.MissingPersons;

namespace MCSA_API.Domain.MissingPersons;

public interface IMissingPersonService
{
    Task<(string, int)> CreateMissingPersonAsync(CreateMissingPersonRequest request);
    Task<string> UpdateMissingPersonAsync(UpdateMissingPersonRequest request);
    Task<PagedMissingPersonsResult> GetMissingPersonsAsync(int pageNumber, int pageSize);
    Task<MissingPerson> GetMissingPersonByIdAsync(int id);
}