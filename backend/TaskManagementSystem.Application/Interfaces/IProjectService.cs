using TaskManagementSystem.Application.DTOs.Project;

namespace TaskManagementSystem.Application.Interfaces;

public interface IProjectService
{
    Task<IEnumerable<ProjectResponseDto>> GetAllAsync();

    Task<ProjectResponseDto?> GetByIdAsync(Guid id);

    Task CreateAsync(CreateProjectDto dto);

    Task UpdateAsync(Guid id, UpdateProjectDto dto);

    Task DeleteAsync(Guid id);
}