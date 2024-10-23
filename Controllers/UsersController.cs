using Daniel.Models;
using Daniel.Service;
using Microsoft.AspNetCore.Mvc;

namespace Daniel.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        //dependency injection
        //Daniel do you know your SOLID
        //Daniel read up on the different types of dependency injection in .net
        // builder.Services.AddSingleton<IUserservice, UserService>();
        //builder.Services.AddTransient<IUserservice, UserService>();
        //builder.Services.AddScoped<IUserservice, UserService>();
        private readonly IUserservice _userService;

        public UsersController(IUserservice userService) { 
            _userService = userService;
        }

        //c# async await
        //200, 500, 401, 301 oe 302, 404
        //GET and POST
        [HttpGet("FetchUsers")]
        public async Task<IActionResult> FetchUsers()
        {
            return Ok(await _userService.GetUsers());
        }


        [HttpGet("all_users")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var allUsers = await _userService.GetUsers();
            return Ok(allUsers);
        }


        [HttpGet]
        [Route("users/all_users_v2")]
        public async Task<IActionResult> GetAllUsersAsyncV2()
        {
            var databaseUsers = await _userService.GetUsers();
            return Ok(databaseUsers);
        }

        //Assignment
        //Create a controller method, that adds a user to the users list
        //and confirm the user was added by calling the get all users endpoint
    }
}
