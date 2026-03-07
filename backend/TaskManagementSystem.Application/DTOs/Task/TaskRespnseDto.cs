using TaskManagementSystem.Domain.Enums;
namespace TaskManagementSystem.Application.DTOs.Task;

public class TaskResponseDto
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public TaskItemStatus Status { get; set; }

    public TaskPriority Priority { get; set; }

    public Guid ProjectId { get; set; }

    public Guid AssignedToUserId { get; set; }

    public DateTime? DueDate { get; set; }
}