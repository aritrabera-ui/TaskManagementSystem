namespace TaskManagementSystem.Application.DTOs.Comment;

public class CreateCommentDto
{
    public Guid TaskId { get; set; }

    public Guid UserId { get; set; }

    public string Message { get; set; } = string.Empty;
}