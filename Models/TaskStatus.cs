namespace TaskManagement.API;

public class TaskStatus
{
    public int TaskStatusId { get; set; }
    public string? TaskStatusName { get; set; }
    public string? TaskStatusDescription { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
