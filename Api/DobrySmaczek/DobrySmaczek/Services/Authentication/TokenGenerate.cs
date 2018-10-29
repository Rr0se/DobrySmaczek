using DobrySmaczek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using DobrySmaczek.Services.AppSettingsService;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using DobrySmaczek.Services.Authentication.Models;
using DobrySmaczek.Services.JWT;

namespace DobrySmaczek.Services.Authentication
{
    public class TokenGenerate
    {
        public string TokenAuthenticateGenerate(UserModel user)
        {
            var jwtKey = AppSettingsService.AppSettingsService.Secret;
            var jwtIssuer = AppSettingsService.AppSettingsService.IssuserName;
            var jwtAudience = AppSettingsService.AppSettingsService.AudienceName;
            var jwtExpiry = int.Parse(AppSettingsService.AppSettingsService.ExpiredSecondTime);

            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(TokenClaim.UserId.ToString(), user.Id.ToString()),
                //new System.Security.Claims.Claim(TokenClaim.IdentyficationGuid.ToString(), user.IdentyficationGuid.ToString()),
                //new System.Security.Claims.Claim(TokenClaim.IsOperator.ToString(), user.IsOperator.ToString()),
                //new System.Security.Claims.Claim(TokenClaim.UserRoleId.ToString(), ((int)user.UserType).ToString()),
                new System.Security.Claims.Claim(ClaimTypes.Name, user.Id.ToString()),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

            };

            if (user.ClaimsUser != null)
            {
                var userClaims = user.ClaimsUser.Split(',').ToList();
                foreach (var claim in userClaims)
                {
                    claims.Add(new System.Security.Claims.Claim("UserClaim", claim));
                }
            }

            var token = new JwtSecurityToken(
                issuer: jwtIssuer,
                audience: jwtAudience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(jwtExpiry),
                signingCredentials: new SigningCredentials(
                    JwtSecurityKey.Create(jwtKey),
                    SecurityAlgorithms.HmacSha256));
            var ret = new JwtToken(token).Value;
            return new JwtToken(token).Value;
        }
    }
}
