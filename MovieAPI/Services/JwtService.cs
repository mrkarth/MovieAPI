using Microsoft.IdentityModel.Tokens;
using MovieAPI.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MovieAPI.Services
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GenerateToken(string username, string role)
        {
            var key = _configuration["Jwt:Key"];

            var issuer = _configuration["Jwt:Issuer"];

            var audience = _configuration["Jwt:Audience"];

            var duration = Convert.ToDouble(_configuration["Jwt:DurationInMinutes"]);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),

                new Claim(ClaimTypes.Role, role)
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token =
                new JwtSecurityToken(
                    issuer,
                    audience,
                    claims,
                    expires:DateTime.Now.AddMinutes(duration),
                    signingCredentials:credentials
                    );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        
    }
}
