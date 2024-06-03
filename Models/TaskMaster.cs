using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.API;

public class TaskMaster
{
    public int TaskId { get; set; }
    public string? TaskTitle { get; set; }
    public string? TaskDescription { get; set; }
    public DateTime? TaskStartDate { get; set; }
    public DateTime? TaskEndDate { get; set; }
    [ForeignKey("TaskPriorityId")]
    public int TaskPriorityId { get; set; }
    public TaskPriority? TaskPriority { get; set; }
    [ForeignKey("TaskStatusId")]
    public int TaskStatusId { get; set; }
    public TaskStatus? TaskStatus { get; set; }
    [ForeignKey("TaskCategoryId")]
    public int TaskCategoryId { get; set; }
    public TaskCategory? TaskCategory { get; set; }
    public int TaskAssignId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
    public string? TaskAttachment { get; set; }
    [ForeignKey("TaskCommentId")]
    public string? TaskAssignTo { get; set; }
    public string? TaskAssignBy { get; set; }
}