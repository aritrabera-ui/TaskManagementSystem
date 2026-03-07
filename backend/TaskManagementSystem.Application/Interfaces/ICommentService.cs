using TaskManagementSystem.Application.DTOs.Comment;

namespace TaskManagementSystem.Application.Interfaces;

public interface ICommentService
{
    Task<IEnumerable<CommentResponseDto>> GetByTaskIdAsync(Guid taskId);

    Task CreateAsync(CreateCommentDto dto);
}