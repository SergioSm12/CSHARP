using ustatickets.Models;

namespace ustatickets.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public List<Director> Directors { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }
        public NewMovieDropdownsVM()
        {
            Directors = new List<Director>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }

    }
}
