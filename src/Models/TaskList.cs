namespace YATDA.TaskService.Models;

public class TaskList
{
    public Guid Id { get; set; }
    public List<Task> Tasks { get; set; }
}