using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                       serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Olympus Has Fallen",
                        ReleaseDate = DateTime.Parse("1998-2-12"),
                        Genre = "Thriller",
                        Price = 7.88m

                    },
                    new Movie
                    {
                        Title = "300",
                        ReleaseDate = DateTime.Parse("1999-2-15"),
                        Genre = "Mythology",
                        Price = 9.88m

                    },
                    new Movie
                    {
                        Title = "Twelve Angry Men",
                        ReleaseDate = DateTime.Parse("2001-4-12"),
                        Genre = "Drama",
                        Price = 7.56m
                    },
                    new Movie
                    {
                        Title = "Jaws",
                        ReleaseDate = DateTime.Parse("1995-2-12"),
                        Genre = "Thriller",
                        Price = 8.28m
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
