using Microsoft.AspNetCore.Mvc;
using MovieAPI.Dto;
using MovieAPI.Interfaces;
using MovieAPI.Model;
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

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies = _movieService.GetAllMovies();

            return Ok(movies);
        }
    }
}
