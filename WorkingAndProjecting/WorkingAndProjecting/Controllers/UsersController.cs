using Microsoft.AspNetCore.Mvc;
using WorkingAndProjecting.Contracts.DTOs;
using WorkingAndProjecting.Contracts.Interfaces;
using WorkingAndProjecting.Contracts.Responses;

namespace WorkingAndProjecting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] UserDto newUser)
        {
            if (newUser == null)
                return BadRequest(new ApiResponse<object> { Success = false, Message = "User data is required." });

            var createdUser = await _userService.AddAsync(newUser);

            if (createdUser == null)
                return BadRequest(new ApiResponse<object> { Success = false, Message = "Failed to create the user." });

            return Ok(new ApiResponse<UserDto> { Success = true, Message = "New user has been created", Data = createdUser });
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return BadRequest(new ApiResponse<object> { Success = false, Message = "User id is invalid" });

            var deletedUser = await _userService.DeleteAsync(id);

            if(deletedUser == null)
                return NotFound(new ApiResponse<object> { Success = false, Message = "Failed to delete the user. User not found."});

            return Ok(ApiResponse<object>.NoContent("User deleted successfully."));
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null)
                return NotFound(new ApiResponse<object> { Success = false, Message = "User not found." });

            return Ok(new ApiResponse<UserDto> { Success = true, Message = "User found.", Data = user });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();
            if (users == null)
                return NotFound(new ApiResponse<object> { Success = false, Message = "Users are not found" });

            return Ok(new ApiResponse<List<UserDto>> { Success = true, Message = "Users have been found!", Data = users });

        }
    }
}
