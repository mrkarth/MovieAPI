using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
