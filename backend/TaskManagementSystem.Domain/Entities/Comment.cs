using TaskManagementSystem.Domain.Common;

namespace TaskManagementSystem.Domain.Entities;

public class Comment : BaseEntity
{
    public string Message { get; set; } = string.Empty;

    public Guid TaskId { get; set; }

    public TaskItem? Task { get; set; }

    public Guid UserId { get; set; }

    public User? User { get; set; }
}