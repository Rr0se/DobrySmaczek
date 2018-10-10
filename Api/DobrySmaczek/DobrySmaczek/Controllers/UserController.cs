using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using DobrySmaczek.Services;
using DobrySmaczek.Models;
using DobrySmaczek.Entities;
using DobrySmaczek.Services.User;
using DobrySmaczek.Helpers;

namespace DobrySmaczek.Controllers
{
    [Authorize]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly DataBaseContext context;
        private readonly IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UserController(
           IUserService userService,
           IMapper mapper,
           IOptions<AppSettings> appSettings)
        {
            userService = _userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]UserModel userModel)
        {
            var user = _userService.Authenticate(userModel.UserName, userModel.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            // return basic user info (without password) and token to store client side
            return Ok(new
            {
                Id = user.Id,
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = tokenString
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserModel userModel)
        {
            // map dto to entity
            var user = _mapper.Map<User>(userModel);

            try
            {
                // save 
                _userService.Create(user, userModel.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            var userModel = _mapper.Map<IList<UserModel>>(users);
            return Ok(userModel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            var userModel= _mapper.Map<UserModel>(user);
            return Ok(userModel);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]UserModel userModel)
        {
            // map dto to entity and set id
            var user = _mapper.Map<User>(userModel);
            user.Id = id;

            try
            {
                // save 
                _userService.Update(user, userModel.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }
        //public UserController(DataBaseContext context, IUserService _userService)
        //{
        //    this.context = context;
        //    userService = _userService;
        //}


        //public IActionResult Register()
        //{
        //    var output = userService.Register();
        //    return StatusCode(200, output);
        //}




    }
}
