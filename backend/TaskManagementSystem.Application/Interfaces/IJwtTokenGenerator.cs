using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Application.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}