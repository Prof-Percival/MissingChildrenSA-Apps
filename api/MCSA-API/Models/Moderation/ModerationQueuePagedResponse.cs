namespace MCSA_API.Models.Moderation;

public class ModerationQueuePagedResponse
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public List<ModerationQueueItemResponse> Items { get; set; }
}