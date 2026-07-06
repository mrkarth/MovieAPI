using MovieAPI.Model;

namespace MovieAPI.Interfaces
{
    public interface IMovieRepository
    {
        Movie Add(Movie movie);

        List<Movie> GetAll();

        Movie GetById(int id);

        void Delete(int id);
    }
}
