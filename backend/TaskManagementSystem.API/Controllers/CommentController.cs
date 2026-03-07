using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Application.DTOs.Comment;
using TaskManagementSystem.Application.Interfaces;

namespace TaskManagementSystem.API.Controllers;

[ApiController]
[Route("api/comments")]
[Authorize]
public class CommentController : ControllerBase
{
    private readonly ICommentService _service;

    public CommentController(ICommentService service)
    {
        _service = service;
    }

    [HttpGet("task/{taskId}")]
    public async Task<IActionResult> GetByTaskId(Guid taskId)
    {
        return Ok(await _service.GetByTaskIdAsync(taskId));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCommentDto dto)
    {
        await _service.CreateAsync(dto);
        return Ok();
    }
}