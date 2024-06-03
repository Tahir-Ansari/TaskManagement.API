namespace TaskManagement.API;

public class TaskAssign
{
    public int TaskAssignId { get; set; }
    public int TaskId { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
