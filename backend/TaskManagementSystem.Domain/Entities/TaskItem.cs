using TaskManagementSystem.Domain.Common;
using TaskManagementSystem.Domain.Enums;

namespace TaskManagementSystem.Domain.Entities;

public class TaskItem : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Guid ProjectId { get; set; }

    public Project? Project { get; set; }

    public Guid AssignedToUserId { get; set; }

    public User? AssignedUser { get; set; }

    public TaskItemStatus Status { get; set; } = TaskItemStatus.Todo;

    public TaskPriority Priority { get; set; } = TaskPriority.Medium;

    public DateTime? DueDate { get; set; }

    public ICollection<Comment>? Comments { get; set; }
}