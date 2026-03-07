using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Domain.Entities;
using TaskManagementSystem.Domain.Interfaces;
using TaskManagementSystem.Infrastructure.Data;

namespace TaskManagementSystem.Infrastructure.Repositories;

public class ProjectRepository : Repository<Project>, IProjectRepository
{
    public ProjectRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Project>> GetProjectsByUserIdAsync(Guid userId)
    {
        return await _context.Projects
            .Where(p => p.OwnerId == userId)
            .ToListAsync();
    }
}