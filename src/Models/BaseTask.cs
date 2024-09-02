namespace YATDA.TaskService.Models;

public class BaseTask
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
}