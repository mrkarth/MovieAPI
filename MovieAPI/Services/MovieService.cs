using Microsoft.EntityFrameworkCore;
using MovieAPI.Dto;
using MovieAPI.Interfaces;
using MovieAPI.Model;

namespace MovieAPI.Services
{
    public class MovieService : IMovieService
    {
        public readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MovieResponseDto>> GetAllMoviesAsync()
        {
            var movies = await _repository.GetAllMoviesAsync();
            return movies.Select(m => new MovieResponseDto
            {
                Id = m.Id,
                Title = m.Title,
                Year = m.Year
            }
                ).ToList();
        }
        public async Task<MovieResponseDto> CreateMovieAsync(CreateMovieDto dto)
        {
            if (dto.Year < 1900)
            {
                throw new Exception("Year should be greater that 1900");
            }

            Movie movie = new Movie
            {
                Title = dto.Title,
                Year = dto.Year
            };

            movie = await _repository.AddMovieAsync(movie);

            return new MovieResponseDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Year = movie.Year
            };

        }
        public void DeleteMovieById(int id)
        {
            var movie = _repository.GetById(id);
            if(movie == null)
            {
                throw new Exception("Movie not found");
            }
            _repository.Delete(id);
        }
    }
}
