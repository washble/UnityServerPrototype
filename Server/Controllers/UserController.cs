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
    
    [HttpGet("{deviceId}")]
    public async Task<IActionResult> GetUserAsync([FromRoute] string deviceId)
    {
        // Checking is user exist
        User user = await _userService.GetUserAsync(deviceId);

        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> AddUserAsync([FromBody] User user)
    {
        // Add user to DB
        User userInfo = await _userService.AddUserAsync(user);
        
        return Ok(userInfo);
    }
} 