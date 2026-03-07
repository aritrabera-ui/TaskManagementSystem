using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Domain.Interfaces;

public interface IProjectRepository : IRepository<Project>
{
    Task<IEnumerable<Project>> GetProjectsByUserIdAsync(Guid userId);
}