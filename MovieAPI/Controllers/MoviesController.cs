using Microsoft.AspNetCore.Mvc;
using MovieAPI.Dto;
using MovieAPI.Interfaces;
using MovieAPI.Model;
using MovieAPI.Services;
using System.Reflection;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        public IActionResult CreateMovie(MovieResponseDto dto)
        {
            var movie = _movieService.CreateMovie(dto);

            return Created($"/api/Movies/{movie.Id}", movie);
        }
    }
}
