namespace OneHasToDoThings.Domain;

public class ToDo
{
    public Guid Id { get; set; }
    public string TaskName { get; set; } = "New Task";
    public string TaskDescription { get; set; } = string.Empty;
    public DateTimeOffset Created { get; } = DateTimeOffset.Now;
    public TaskType Type { get; set; } = TaskType.New;
    public DateTimeOffset Completed { get; set; } = DateTimeOffset.MinValue;
}
