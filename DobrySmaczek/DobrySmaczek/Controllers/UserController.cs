using DobrySmaczek.Entities;
using DobrySmaczek.Models;
using DobrySmaczek.Services.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly DataBaseContext context;
        private readonly IUserService userService;

        public UserController(DataBaseContext context, IUserService _userService)
        {
            this.context = context;
            userService = _userService;
        }


        public IActionResult Register()
        {
            var output = userService.Register();
            return StatusCode(200, output);
        }



        private Models.User GenerateUser(int Id)
        {
            var user = context.Users.FirstOrDefault(x => x.Id == Id);
            if (user == null)
            {
                return null;
            }
            var output = new Models.User
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Adress = user.Adress

            };

            return output;
        }

        //[HttpGet("GetUser")]
        //public IActionResult GetUser(int Id)
        //{
        //    var output = new User
        //    {
        //        Users = GenerateUser(Id),
        //    };
        //    return StatusCode(200, output);

        //}



    }
}
