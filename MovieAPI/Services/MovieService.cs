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
        public MovieResponseDto CreateMovie(MovieResponseDto dto)
        {
            if(dto.Year < 1900)
            {
                throw new Exception("Year must be greater than or equal to 1900");
            }

            Movie movie = new Movie
            {
                Id = 1,
                Title = dto.Title,
                Year = dto.Year
            };

            _repository.Add(movie);

            return new MovieResponseDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Year = movie.Year
            };

        }
    }
}
