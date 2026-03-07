using TaskManagementSystem.Domain.Common;

namespace TaskManagementSystem.Domain.Entities;

public class User : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string Role { get; set; } = "User";

    public ICollection<Project>? Projects { get; set; }

    public ICollection<TaskItem>? AssignedTasks { get; set; }

    public ICollection<Comment>? Comments { get; set; }
}