using DobrySmaczek.Entities;
using DobrySmaczek.Models;
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

        public UserController(DataBaseContext context)
        {
            this.context = context;
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

        [HttpGet("GetUser")]
        public IActionResult GetUser(int Id)
        {
            var output = new User
            {
                Users = GenerateUser(Id),
            };
            return StatusCode(200, output);

        }

    }
}
