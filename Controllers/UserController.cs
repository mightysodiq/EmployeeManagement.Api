using EmployeeManagement.Api.Dtos;
using EmployeeManagement.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser([FromBody] CreateUserDto model)
        {
            var createUserResponse = await _userRepository.AddUser(model);

            return Ok(createUserResponse);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var loginResponse = await _userRepository.Login(model);

            return Ok(loginResponse);

        }
    }
}
