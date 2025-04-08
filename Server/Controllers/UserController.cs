using Microsoft.AspNetCore.Mvc;
using Server.Services;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet("{device}/{playerId}")]
    public async Task<IActionResult> Get([FromRoute] User user)
    {
        // Add user to DB
        User newUser = await _userService.AddUserAsync(user);

        return Ok(newUser);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        // Add user to DB
        User newUser = await _userService.AddUserAsync(user);
        
        return Ok(newUser);
    }
} 