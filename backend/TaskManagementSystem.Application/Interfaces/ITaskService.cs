using TaskManagementSystem.Application.DTOs.Task;

namespace TaskManagementSystem.Application.Interfaces;

public interface ITaskService
{
    Task<IEnumerable<TaskResponseDto>> GetAllAsync();

    Task<TaskResponseDto?> GetByIdAsync(Guid id);

    Task CreateAsync(CreateTaskDto dto);

    Task UpdateAsync(Guid id, UpdateTaskDto dto);

    Task DeleteAsync(Guid id);
}