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

        //[AllowAnonymous]
        //[HttpPost("authenticate")]
        //public IActionResult Authenticate([FromBody]UserModel userModel)
        //{
        //    var user = _userService.Authenticate(userModel.UserName, userModel.Password);

        //    if (user == null)
        //        return BadRequest(new { message = "Username or password is incorrect" });

        //    var jwtKey = AppSettingsService.AppSettingsService.Secret;
        //    var jwtIssuer = AppSettingsService.AppSettingsService.IssuserName;
        //    var jwtAudience = AppSettingsService.AppSettingsService.AudienceName;
        //    var jwtExpiry = int.Parse(AppSettingsService.AppSettingsService.ExpiredSecondTime);

        //    var claims = new List<System.Security.Claims.Claim>
        //    {
        //        new System.Security.Claims.Claim(TokenClaim.UserId.ToString(), user.Id.ToString()),
        //        //new System.Security.Claims.Claim(TokenClaim.IdentyficationGuid.ToString(), user.IdentyficationGuid.ToString()),
        //        //new System.Security.Claims.Claim(TokenClaim.IsOperator.ToString(), user.IsOperator.ToString()),
        //        //new System.Security.Claims.Claim(TokenClaim.UserRoleId.ToString(), ((int)user.UserType).ToString()),
        //        new System.Security.Claims.Claim(ClaimTypes.Name, user.Id.ToString()),
        //        new System.Security.Claims.Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

        //    };

        //    if (user.ClaimsUser != null)
        //    {
        //        var userClaims = user.ClaimsUser.Split(',').ToList();
        //        foreach (var claim in userClaims)
        //        {
        //            claims.Add(new System.Security.Claims.Claim("UserClaim", claim));
        //        }
        //    }

        //    var token = new JwtSecurityToken(
        //        issuer: jwtIssuer,
        //        audience: jwtAudience,
        //        claims: claims,
        //        expires: DateTime.UtcNow.AddMinutes(jwtExpiry),
        //        signingCredentials: new SigningCredentials(
        //            JwtSecurityKey.Create(jwtKey),
        //            SecurityAlgorithms.HmacSha256));
        //    var ret = new JwtToken(token).Value;
        //    return new JwtToken(token).Value;
        //}

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserModel userModel)
        {
            // map dto to entity
            var user = _mapper.Map<AppUser>(userModel);

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
            var user = _mapper.Map<AppUser>(userModel);
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
       

    }
}
