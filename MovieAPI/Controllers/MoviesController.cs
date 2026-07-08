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
        public IActionResult CreateMovie(CreateMovieDto dto)
        {
            var result = _movieService.CreateMovie(dto);

            return Ok(result);

        }

        [HttpDelete]
        public IActionResult DeleteMovie(int id)
        {
            _movieService.DeleteMovieById(id);

            return NoContent();
        }
    }
}


