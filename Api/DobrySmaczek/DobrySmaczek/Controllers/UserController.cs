using DobrySmaczek.Services.User;
using DobrySmaczek.Services.User.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DobrySmaczek.Controllers
{
    [AllowAnonymous]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
          
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserInputViewModel userModel)
        {
            var response = _userService.Register(userModel);
            if (response.ServiceResponse != ServiceResponseEnum.Ok)
                return StatusCode((int) HttpStatusCode.BadRequest, response.Message);
            return StatusCode((int) HttpStatusCode.OK);
        }

        [HttpPost("login")]
        public IActionResult Login(string email, string password)
        {
            var response = _userService.Login(email, password);
            if (response.ServiceResponse != ServiceResponseEnum.Ok)
                return StatusCode((int)HttpStatusCode.BadRequest, response.Message);
            return StatusCode((int)HttpStatusCode.OK);
        }

    }
}
