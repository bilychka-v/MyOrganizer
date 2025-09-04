namespace Domain;

public class Tasks
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public TaskStatus Status { get; set; }
    public Guid UserId { get; set; }
    public TaskPriority Priority { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime CompletedAt { get; set; }
}

public enum TaskPriority
{
    Low, 
    Medium, 
    High
}

public enum TaskStatus
{
    NotStarted, 
    InProgress,  
    Completed,   
    Overdue      
}
