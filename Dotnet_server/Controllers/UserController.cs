using AutoMapper;
using Dotnet_server.Data;
using Dotnet_server.Models;
using Microsoft.AspNetCore.Mvc;
namespace Dotnet_server.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase
{
    IUserRepository _userRepository;
    IMapper _mapper;
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
        _mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<UserDto, User>();
        }));
    }
    [HttpGet("GetUser")]
    public IActionResult GetUser()
    {
        var user = new UserDto() { FirstName = "Taye", LastName = "Dotnet", Email = "dotnet@gmail.com", Active = true };
        IEnumerable <User> users = _userRepository.GetUsers();
        return Ok(users);
    }
    [HttpPost("AddUser")]
    public IActionResult AddUser(UserDto user)
    {
        User userDb = _mapper.Map<User>(user);
        _userRepository.AddEntity(userDb);
        if (_userRepository.SaveChanges())
        {
            return Ok(user);
        }
        throw new Exception("Failed to add user");
    }
}