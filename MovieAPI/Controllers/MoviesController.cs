using Microsoft.AspNetCore.Mvc;
using MovieAPI.Dto;
using MovieAPI.Model;
using System.Reflection;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateMovie([FromBody] CreateMovieDto Dto)
        {
            Movie movie = new Movie
            {
                Id = 1,
                Title = Dto.Title,
                Year = Dto.Year,
                CreatedDate = DateTime.Now
            };


            MovieResponseDto response = new MovieResponseDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Year = movie.Year
            };


            return Created($"/api/Movies/{movie.Id}", response);
        }
    }
}
