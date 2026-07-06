using MovieAPI.Interfaces;
using MovieAPI.Model;

namespace MovieAPI.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private static List<Movie> movies = new();

        public Movie Add(Movie movie)
        {
            movies.Add(movie);

            return movie;
        }

        public List<Movie> GetAll()
        {
            return movies;
        }

        public Movie GetById(int Id)
        {
            return movies.FirstOrDefault(x => x.Id == Id);
        }

        public void Delete(int id)
        {
            var movie = GetById(id);

            if (movie != null)
                movies.Remove(movie);
        }

    }
}
