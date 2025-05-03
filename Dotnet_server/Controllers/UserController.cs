using Dotnet_server.Models;
using Microsoft.AspNetCore.Mvc;
namespace Dotnet_server.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase
{
    private readonly IConfiguration _config;
    public UserController(IConfiguration config)
    {
        _config = config;

    }
    [HttpGet]
    public IActionResult Get()
    {
        var user = new UserDto() { FirstName = "Taye", LastName = "Dotnet", Email = "dotnet@gmail.com", Active = true };
        return Ok(user);
    }
}