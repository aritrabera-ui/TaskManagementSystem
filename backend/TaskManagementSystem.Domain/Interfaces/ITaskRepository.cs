using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Domain.Interfaces;

public interface ITaskRepository : IRepository<TaskItem>
{
    Task<IEnumerable<TaskItem>> GetTasksByProjectIdAsync(Guid projectId);

    Task<IEnumerable<TaskItem>> GetTasksByUserIdAsync(Guid userId);
}