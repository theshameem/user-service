using Application.Commands;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("/register")]
    public IActionResult Register([FromBody] RegiserUserCommand request)
    {
        // Registration logic goes here

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