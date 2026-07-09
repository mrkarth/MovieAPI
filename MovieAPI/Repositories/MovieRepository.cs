using Microsoft.EntityFrameworkCore;
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
        public async Task<Movie> AddMovieAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }
        public Movie GetById(int id)
        {
            return _context.Movies.Find(id);
        }

        public void Delete(int id)
        {
            var movie =  _context.Movies.Find(id);
            if(movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChangesAsync();
            }
        }
    }
}
