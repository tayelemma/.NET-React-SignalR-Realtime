using Dotnet_server.Data;
using Dotnet_server.Models;
using Microsoft.AspNetCore.Mvc;
namespace Dotnet_server.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase
{
    public UserController()
    {

    }
    [HttpGet("GetUser")]
    public IActionResult GetUser()
    {
        var user = new UserDto() { FirstName = "Taye", LastName = "Dotnet", Email = "dotnet@gmail.com", Active = true };
        return Ok(user);
    }
    [HttpPost("AddUser")]
    public IActionResult AddUser(UserDto user)
    {
        return Ok(user);
    }
}