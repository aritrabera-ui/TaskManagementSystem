using TaskManagementSystem.Application.DTOs.Project;
using TaskManagementSystem.Application.Interfaces;
using TaskManagementSystem.Domain.Entities;
using TaskManagementSystem.Domain.Interfaces;

namespace TaskManagementSystem.Application.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _repository;

    public ProjectService(IProjectRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ProjectResponseDto>> GetAllAsync()
    {
        var projects = await _repository.GetAllAsync();

        return projects.Select(p => new ProjectResponseDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            OwnerId = p.OwnerId
        });
    }

    public async Task<ProjectResponseDto?> GetByIdAsync(Guid id)
    {
        var project = await _repository.GetByIdAsync(id);

        if (project == null) return null;

        return new ProjectResponseDto
        {
            Id = project.Id,
            Name = project.Name,
            Description = project.Description,
            OwnerId = project.OwnerId
        };
    }

    public async Task CreateAsync(CreateProjectDto dto)
    {
        var project = new Project
        {
            Name = dto.Name,
            Description = dto.Description,
            OwnerId = dto.OwnerId
        };

        await _repository.AddAsync(project);
    }

    public async Task UpdateAsync(Guid id, UpdateProjectDto dto)
    {
        var project = await _repository.GetByIdAsync(id);

        if (project == null) return;

        project.Name = dto.Name;
        project.Description = dto.Description;

        _repository.Update(project);
    }

    public async Task DeleteAsync(Guid id)
    {
        var project = await _repository.GetByIdAsync(id);

        if (project == null) return;

        _repository.Delete(project);
    }
}