using Application.Commands;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class UserRepositoryService: IUserRepositoryService
{
    private readonly ApplicationDbContext _context;

    public UserRepositoryService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task RegisterUser(RegiserUserCommand command)
    {
       var user = new User
       {
            Email = command.Email,
            FirstName = command.FirstName,
            LastName = command.LastName,
            PasswordHash = $"{command.Password} shameem",
            IsActive = true,
            IsEmailEnabled = true,
            IsPushEnabled = true,
            IsSmsEnabled  = true,
            FullName = $"{command.FirstName} {command.LastName}",
            Roles = new List<string> { "user" }
       };

       _context.Users.Add(user);

       await _context.SaveChangesAsync();
    }
}