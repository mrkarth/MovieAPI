using MovieAPI.Dto;
using MovieAPI.Model;

namespace MovieAPI.Interfaces
{
    public interface IMovieService
    {
        MovieResponseDto CreateMovie(CreateMovieDto dto);

        //Movie GetById(int id);
        public void DeleteMovieById(int id);
    }
}
