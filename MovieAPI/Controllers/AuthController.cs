using Microsoft.AspNetCore.Mvc;
using MovieAPI.Dto;
using MovieAPI.Interfaces;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IJwtService _jwtService;

        public AuthController(IJwtService JwtService)
        {
            _jwtService = JwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto request)
        {
            if(request.Username != "" || request.Password != "")
            {
                return Unauthorized();
            }

            var token = _jwtService.GenerateToken(request.Username, "Admin");

            return Ok(new
            {
                Token = token
            }
                );
        }

    }
}
