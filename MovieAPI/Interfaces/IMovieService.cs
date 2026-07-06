using MovieAPI.Dto;

namespace MovieAPI.Interfaces
{
    public interface IMovieService
    {
        MovieResponseDto CreateMovie(MovieResponseDto dto);
    }
}
