using Daniel.Service;
using Microsoft.AspNetCore.Mvc;

namespace Daniel.Controllers
{
    public class MemberController:Controller
    {
        private readonly IUserservice _userservice;
        public MemberController(IUserservice userservice)
        {
            _userservice = userservice;
        }

        public async Task<IActionResult> Index()
        {
            //get all users
            //pass all users to html view
            //list all users in view
            var users = await _userservice.GetUsers();
            return View(users);
        }
    }
}
