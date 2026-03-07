using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Domain.Entities;
using TaskManagementSystem.Domain.Interfaces;
using TaskManagementSystem.Infrastructure.Data;

namespace TaskManagementSystem.Infrastructure.Repositories;

public class TaskRepository : Repository<TaskItem>, ITaskRepository
{
    public TaskRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<TaskItem>> GetTasksByProjectIdAsync(Guid projectId)
    {
        return await _context.Tasks
            .Where(t => t.ProjectId == projectId)
            .ToListAsync();
    }

    public async Task<IEnumerable<TaskItem>> GetTasksByUserIdAsync(Guid userId)
    {
        return await _context.Tasks
            .Where(t => t.AssignedToUserId == userId)
            .ToListAsync();
    }
}