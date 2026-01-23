using Application.Commands;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserRepositoryService _userRepositoryService;
    public AuthController(IUserRepositoryService userRepositoryService)
    {
        _userRepositoryService = userRepositoryService;
    }

    [HttpPost("/register")]
    public async Task<IActionResult> Register([FromBody] RegiserUserCommand request)
    {
        // Registration logic goes here
        await _userRepositoryService.RegisterUser(request);
        
        return Ok("User registered successfully.");
    }

    [HttpPost("/login")]
    public IActionResult Login([FromBody] LoginUserCommand request)
    {
        // Login logic goes here

        return Ok("User logged in successfully.");
    }

    [HttpPost("/logout")]
    public IActionResult Logout()
    {
        // Logout logic goes here

        return Ok("User logged out successfully.");
    }
}