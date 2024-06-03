namespace TaskManagement.API;

public class TaskCategory
{
    public int TaskCategoryId { get; set; }
    public string? TaskCategoryName { get; set; }
    public string? TaskCategoryDescription { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
