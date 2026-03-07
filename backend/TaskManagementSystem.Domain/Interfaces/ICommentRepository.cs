using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Domain.Interfaces;

public interface ICommentRepository : IRepository<Comment>
{
    Task<IEnumerable<Comment>> GetCommentsByTaskIdAsync(Guid taskId);
}