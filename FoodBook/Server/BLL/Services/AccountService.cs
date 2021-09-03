using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using BO.DTO.Responses;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace BLL.Services
{
    class AccountService : IAccountService
    {
        private readonly IConfiguration _configuration;
        public AccountService (IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<LoginResponse> Login(string username, string password)
        {
            //Rechercher dans la base de donnée : 
            //TODO : V2 : Implémenter Client et Role dans la base de données.
            var loginResponse = new LoginResponse()
            {
                Username = username,
                AccessToken = GenerateJwtToken(username, new List<string>() {"Admin", "User"})
            };
            
            return Task.FromResult(loginResponse);
        }

        private string GenerateJwtToken(string username, List<string> roles)
        {

            //Add User Info
            var claims = new List<Claim>
            {
                new Claim (JwtRegisteredClaimNames.Sub, username),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim (ClaimTypes.NameIdentifier, username)
            };
            //ADD User Role
            roles.ForEach(role =>
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            });
            //Signin Key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //Expiration time
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));
            //Create JWT Roken Object
            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtIssuer"],
                claims,
                expires : expires,
                signingCredentials: creds);
            //Serialize a new JwtSecurity
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
