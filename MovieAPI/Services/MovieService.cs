using MovieAPI.Interfaces;

namespace MovieAPI.Services
{
    public class MovieService : IMovieService
    {
        public List<string> GetAllMovies()
        {
            return new List<string>
            {
                "Avathat",
                "Intersteller",
                "Inception"
            };
        }
    }
}
