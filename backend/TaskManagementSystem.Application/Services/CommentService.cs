using TaskManagementSystem.Application.DTOs.Comment;
using TaskManagementSystem.Application.Interfaces;
using TaskManagementSystem.Domain.Entities;
using TaskManagementSystem.Domain.Interfaces;

namespace TaskManagementSystem.Application.Services;

public class CommentService : ICommentService
{
    private readonly ICommentRepository _repository;

    public CommentService(ICommentRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CommentResponseDto>> GetByTaskIdAsync(Guid taskId)
    {
        var comments = await _repository.GetCommentsByTaskIdAsync(taskId);

        return comments.Select(c => new CommentResponseDto
        {
            Id = c.Id,
            TaskId = c.TaskId,
            UserId = c.UserId,
            Message = c.Message
        });
    }

    public async Task CreateAsync(CreateCommentDto dto)
    {
        var comment = new Comment
        {
            TaskId = dto.TaskId,
            UserId = dto.UserId,
            Message = dto.Message
        };

        await _repository.AddAsync(comment);
    }
}