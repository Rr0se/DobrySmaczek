using DobrySmaczek.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DobrySmaczek.Services.User
{
    public class TokenGenerate: ITokenGenerate
    {
        public string TokenAuthenticateGenerate(AppUser user)
        {
            return new JwtSecurityTokenHandler().WriteToken(new JwtSecurityToken(
                issuer: "DobrySmaczek.API",
                audience: "DobrySmaczek.CLIENT",
                claims: new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(TokenClaim.UserId, user.Id.ToString()),
                },
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: new SigningCredentials(
                    key: new SymmetricSecurityKey(Encoding.ASCII.GetBytes("MySecret")),
                    algorithm: SecurityAlgorithms.HmacSha256)));
        }
    }

    public static class TokenClaim
    {
        public static readonly string UserId = "userId";
        public static readonly string UserRoleId = "userRoleId";

    }
}
