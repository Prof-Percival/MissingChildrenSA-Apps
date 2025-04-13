using MCSA_API.Domain.MissingPersons;
using System.ComponentModel.DataAnnotations;

namespace MCSA_API.Models.MissingPersons;

public class UpdateMissingPersonRequest : CreateMissingPersonRequest
{

    [Required]
    public int? Id { get; set; }

    [Required]
    public MissingPersonStatus? Status { get; set; }
}