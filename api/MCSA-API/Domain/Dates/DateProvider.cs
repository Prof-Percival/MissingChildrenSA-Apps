namespace MCSA_API.Domain.Dates;

public class DateProvider : IDateProvider
{
    public DateTime GetDate()
    {
        return DateTime.UtcNow.AddHours(2);
    }
}