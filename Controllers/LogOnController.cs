using Azure.Identity;
using CGMMiddleWare.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;
using System.Text;

namespace CGMMiddleWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogOnController : ControllerBase
    {
        IConfiguration _configuration;
        public LogOnController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("logon")]
        public IActionResult LogOn(User user)
        {
            if (!string.IsNullOrEmpty(user.username) && !string.IsNullOrEmpty(user.password))
            {
                User _response = new();
                _response = Authenticate(user);
                if (_response != null)
                {
                    string token = GenerateToken();
                    return Ok(new { Token = token });
                }
                return BadRequest();
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, "please enter username or password");
            }
        }

        

        private User? Authenticate(User user)
        {
            User _user = null;
            if (user.username == "tanuj" && user.password == "123")
            {
                _user = new User();
            }
            return _user;

        }

        private string GenerateToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? string.Empty));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], null, null, DateTime.Now.AddMinutes(2), credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
