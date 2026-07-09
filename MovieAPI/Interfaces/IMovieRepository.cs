using MovieAPI.Model;

namespace MovieAPI.Interfaces
{
    public interface IMovieRepository
    {
        Task<Movie> AddMovieAsync(Movie movie);

        Task<List<Movie>> GetAllMoviesAsync();

        Movie GetById(int id);

        //void Delete(int id);
        public void Delete(int id);
    }
}
