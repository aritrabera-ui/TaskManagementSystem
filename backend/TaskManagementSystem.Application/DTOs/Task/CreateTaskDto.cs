using TaskManagementSystem.Domain.Enums;

namespace TaskManagementSystem.Application.DTOs.Task;

public class CreateTaskDto
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Guid ProjectId { get; set; }

    public Guid AssignedToUserId { get; set; }

    public TaskPriority Priority { get; set; }

    public DateTime? DueDate { get; set; }
}