namespace TaskManagementSystem.Application.DTOs.Comment;

public class CommentResponseDto
{
    public Guid Id { get; set; }

    public Guid TaskId { get; set; }

    public Guid UserId { get; set; }

    public string Message { get; set; } = string.Empty;
}