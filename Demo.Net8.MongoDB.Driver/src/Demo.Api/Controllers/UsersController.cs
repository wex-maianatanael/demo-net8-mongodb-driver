using Demo.Application.Contracts;
using Demo.Application.ViewModels;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserApplicationService _userAppService;

        public UsersController(ILogger<UsersController> logger, IUserApplicationService userAppService)
        {
            _logger = logger;
            _userAppService = userAppService;
        }

        [HttpPost()]
        public async Task<IActionResult> PostUser(UserViewModel model)
        {
            var user = new User
            {
                Name = model.Name,
                Age = model.Age
            };

            var result = await _userAppService.CreateAsync(user);
            return CreatedAtAction(nameof(GetUserById), new { userid = result.Id }, result);
        }

        [HttpGet("{userid:length(24)}")]
        public async Task<IActionResult> GetUserById(string userid)
        {
            var response = await _userAppService.GetByIdAsync(userid);

            if (response == null) return NotFound();

            return Ok(response);
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _userAppService.GetAllAsync();

            if (response == null || response.Count == 0) return NotFound();

            return Ok(response);
        }
    }
}
