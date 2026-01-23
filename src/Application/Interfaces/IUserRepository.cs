using Application.Commands;

namespace Application.Interfaces;

public interface IUserRepositoryService
{
    Task RegisterUser(RegiserUserCommand command);
}