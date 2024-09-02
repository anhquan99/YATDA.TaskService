namespace YATDA.TaskService.Models;

public class Task : BaseTask
{
    public string Description { get; set; }
    public int Status { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public required List<SubTask> SubTasks { get; set; }
    public required List<string> Tags { get; set; }
}