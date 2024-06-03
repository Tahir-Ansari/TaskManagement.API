namespace TaskManagement.API;

public class TaskPriority
{
    public int TaskPriorityId { get; set; }
    public string? TaskPriorityName { get; set; }
    public string? TaskPriorityDescription { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
