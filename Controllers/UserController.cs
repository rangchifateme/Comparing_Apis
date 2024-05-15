using Comparing_Apis.Service;
using Microsoft.AspNetCore.Mvc;

namespace Comparing_Apis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{userId}")]
        public IActionResult GetUser(int userId)
        {
            var user = _userService.GetUser(userId);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            var userId = _userService.AddUser(user.Name, user.Email);
            return Ok(userId);
        }
    }
}
