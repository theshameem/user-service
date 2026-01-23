using Application.Commands;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class UserRepositoryService : IUserRepositoryService
{
    private readonly ApplicationDbContext _context;
    private readonly IPasswordHasherService _passwordHasherService;

    public UserRepositoryService(ApplicationDbContext context, IPasswordHasherService passwordHasherService)
    {
        _context = context;
        _passwordHasherService = passwordHasherService;
    }

    public async Task RegisterUser(RegiserUserCommand command)
    {
        var hashedPassword = _passwordHasherService.HashPassword(command.Password);

        var user = new User
        {
            Email = command.Email,
            FirstName = command.FirstName,
            LastName = command.LastName,
            PasswordHash = hashedPassword,
            IsActive = true,
            IsEmailEnabled = true,
            IsPushEnabled = true,
            IsSmsEnabled = true,
            FullName = $"{command.FirstName} {command.LastName}",
            Roles = new List<string> { "user" }
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();
    }
}