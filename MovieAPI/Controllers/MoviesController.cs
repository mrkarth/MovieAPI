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

        [HttpGet]
        public async Task<IActionResult> GetAllMoviesAsync()
        {
            var movies = await _movieService.GetAllMoviesAsync();
            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovieAsync(CreateMovieDto dto)
        {
            var result = await _movieService.CreateMovieAsync(dto);

            return Created();

        }

        [HttpDelete]
        public IActionResult DeleteMovie(int id)
        {
            _movieService.DeleteMovieById(id);

            return NoContent();
        }
    }
}


