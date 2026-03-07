using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem.Application.Interfaces;
using TaskManagementSystem.Application.Services;

namespace TaskManagementSystem.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IProjectService, ProjectService>();
        services.AddScoped<ITaskService, TaskService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ICommentService, CommentService>();

        return services;
    }
}