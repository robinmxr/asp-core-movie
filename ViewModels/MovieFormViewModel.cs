using MvcMovie.Models;

namespace MvcMovie.ViewModels
{
    public class MovieFormViewModel
    {

        public Movie Movie { get; set; }

        public IEnumerable<Director> Directors { get; set; }
    }
}
