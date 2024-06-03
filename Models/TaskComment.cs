namespace TaskManagement.API;

public class TaskComment
{
    public int TaskCommentId { get; set; }
    public int TaskId { get; set; }
    public string? Comment { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
