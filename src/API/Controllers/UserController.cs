using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        // Get all users logic goes here

        return Ok("All users retrieved successfully.");
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        // Get user by ID logic goes here

        return Ok($"User with ID {id} retrieved successfully.");
    }

    [HttpPost]
    public IActionResult CreateUser()
    {
        // Create user logic goes here

        return Ok("User created successfully.");
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id)
    {
        // Update user logic goes here

        return Ok($"User with ID {id} updated successfully.");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        // Delete user logic goes here

        return Ok($"User with ID {id} deleted successfully.");
    }
}