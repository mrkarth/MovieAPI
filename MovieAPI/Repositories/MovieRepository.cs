using MovieAPI.Data;
using MovieAPI.Interfaces;
using MovieAPI.Model;

namespace MovieAPI.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public Movie Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public Movie GetById(int id)
        {
            return _context.Movies.Find(id);
        }

        public void Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            if(movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }
    }
}
