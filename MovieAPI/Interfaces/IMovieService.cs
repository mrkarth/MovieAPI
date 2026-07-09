using MovieAPI.Dto;
using MovieAPI.Model;

namespace MovieAPI.Interfaces
{
    public interface IMovieService
    {
        Task<MovieResponseDto> CreateMovieAsync(CreateMovieDto dto);

        Task<List<MovieResponseDto>> GetAllMoviesAsync();

        //Movie GetById(int id);
        public void DeleteMovieById(int id);
    }
}
