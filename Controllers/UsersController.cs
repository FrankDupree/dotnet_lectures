using Daniel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Daniel.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private List<UserProfile> userProfiles = new List<UserProfile>();

        public UsersController() { }

        //c# async await
        //200, 500, 401, 301 oe 302, 404
        //GET and POST
        [HttpGet("FetchUsers")]
        public async Task<IActionResult> FetchUsers()
        {
            
            userProfiles.Add( new UserProfile
            {
                name = "Frank",
                country = "Nigeria",
                tribe = "canada"
            });

            userProfiles.Add(new UserProfile
            {
                name = "Daniel",
                country = "Nigeria",
                tribe = "calarbar"
            });

            return Ok(userProfiles);
        }


        [HttpGet("all_users")]
        public async Task<IActionResult> GetAllUsersAsync()
        {

            userProfiles.Add(new UserProfile
            {
                name = "Frank",
                country = "Nigeria",
                tribe = "canada"
            });

            userProfiles.Add(new UserProfile
            {
                name = "Daniel",
                country = "Nigeria",
                tribe = "calarbar"
            });

            return Ok(userProfiles);
        }


        [HttpGet]
        [Route("users/all_users_v2")]
        public async Task<IActionResult> GetAllUsersAsyncV2()
        {

            userProfiles.Add(new UserProfile
            {
                name = "Frank",
                country = "Nigeria",
                tribe = "canada"
            });

            userProfiles.Add(new UserProfile
            {
                name = "Daniel",
                country = "Nigeria",
                tribe = "calarbar"
            });

            return Ok(userProfiles);
        }
    }
}
