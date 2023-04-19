using ChallengeAlternativo.Core.Users;
using ChallengeAlternativo.Core.Users.Services.Interfaces;
using ChallengeAlternativo.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ChallengeAlternativo.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserServices _services;

        public AuthController(IUserServices services)
        {
            _services = services;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register([FromBody] UserDTO userDTO)
        {
            var result = await _services.GetUserByUserName(userDTO.UserName);
            if (result == null)
            {
                var crearuser = await _services.CreateUser(userDTO);
                return Ok(crearuser);
            }
            return BadRequest("El nombre de usuario ya existe");
        }


        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login([FromBody] UserDTO userDTO)
        {
            var user = await _services.GetUserByUserName(userDTO.UserName);
            if (user.UserName != userDTO.UserName)
            {
                return BadRequest("User not found");
            }
            if (!ApiHelper.VerificarContraseña(user.Password,ApiHelper.EncriptarContraseña(userDTO.Password)))
            {
                return BadRequest("Wrong password");
            }
            string token = CreateToken(user);
            return Ok(token);
        }
        private string CreateToken(User request)
        {
            var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, request.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("supersecret_secretkey!123"));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokenOptions = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signinCredentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return tokenString;
        }

    }
}
