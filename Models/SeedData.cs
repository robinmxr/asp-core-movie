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
                if (context.Director.Any())
                {
                    return;
                }
                context.Director.AddRange(
                    new Director
                    {
                        Name = "Satyajit Roy",
                        Details = "Indian Director"

                    },
                    new Director
                    {
                        Name = "Speilburg",
                        Details = "US Director"

                    },
                    new Director
                    {
                        Name = "Tarantino",
                        Details = "Canadian Director"

                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
