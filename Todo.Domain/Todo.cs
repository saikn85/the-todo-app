namespace Todo.Domain;

public class Todo
{
    public Guid TodoId { get; set; }
    public string TheTask { get; set; } = "New Task";
    public DateTimeOffset Created { get; set; }
    public TaskType State { get; set; }
    public DateTimeOffset Completed { get; set; }
}