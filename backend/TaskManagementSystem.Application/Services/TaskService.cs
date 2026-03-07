using TaskManagementSystem.Application.DTOs.Task;
using TaskManagementSystem.Application.Interfaces;
using TaskManagementSystem.Domain.Entities;
using TaskManagementSystem.Domain.Interfaces;

namespace TaskManagementSystem.Application.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _repository;

    public TaskService(ITaskRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<TaskResponseDto>> GetAllAsync()
    {
        var tasks = await _repository.GetAllAsync();

        return tasks.Select(t => new TaskResponseDto
        {
            Id = t.Id,
            Title = t.Title,
            Description = t.Description,
            Status = t.Status,
            Priority = t.Priority,
            ProjectId = t.ProjectId,
            AssignedToUserId = t.AssignedToUserId,
            DueDate = t.DueDate
        });
    }

    public async Task<TaskResponseDto?> GetByIdAsync(Guid id)
    {
        var task = await _repository.GetByIdAsync(id);

        if (task == null) return null;

        return new TaskResponseDto
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            Status = task.Status,
            Priority = task.Priority,
            ProjectId = task.ProjectId,
            AssignedToUserId = task.AssignedToUserId,
            DueDate = task.DueDate
        };
    }

    public async Task CreateAsync(CreateTaskDto dto)
    {
        var task = new TaskItem
        {
            Title = dto.Title,
            Description = dto.Description,
            ProjectId = dto.ProjectId,
            AssignedToUserId = dto.AssignedToUserId,
            Priority = dto.Priority,
            DueDate = dto.DueDate
        };

        await _repository.AddAsync(task);
    }

    public async Task UpdateAsync(Guid id, UpdateTaskDto dto)
    {
        var task = await _repository.GetByIdAsync(id);

        if (task == null) return;

        task.Title = dto.Title;
        task.Description = dto.Description;
        task.Status = dto.Status;
        task.Priority = dto.Priority;
        task.DueDate = dto.DueDate;

        _repository.Update(task);
    }

    public async Task DeleteAsync(Guid id)
    {
        var task = await _repository.GetByIdAsync(id);

        if (task == null) return;

        _repository.Delete(task);
    }
}