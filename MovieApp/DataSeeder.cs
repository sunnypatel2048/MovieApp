using MovieApp.Data;

namespace MovieApp
{
    /// <summary>The DataSeeder Class</summary>
    public static class DataSeeder
    {
        /// <summary>Seeds the specified host.</summary>
        /// <param name="host">The host.</param>
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<MovieDataContext>();
            context.Database.EnsureCreated();
            AddMovies(context);
        }

        /// <summary>Adds the movies.</summary>
        /// <param name="context">The context.</param>
        private static void AddMovies(MovieDataContext context)
        {
            var movie = context.Movies.FirstOrDefault();
            if (movie != null) return;

            context.Movies.Add(new Movie
            {
                Title = "The Shawshank Redemption",
                Year = 1994,
                Summary = "Banker Andy Dufresne is arrested for killing his wife and her lover. After a hard adjustment, he tries to improve the conditions of the prison and to give hope to his companions.",
                Actors = new List<Actor>
                {
                    new Actor { FullName = "Morgan Freeman"},
                    new Actor { FullName = "Tim Robbins"}
                },
                Directors = new List<Director>
                {
                    new Director { FullName = "Frank Darabont"}
                }
            });

            context.Movies.Add(new Movie
            {
                Title = "The Godfather",
                Year = 1972,
                Summary = "The aging patriarch of a New York mafia dynasty passes the torch of his underground empire to his reluctant son",
                Actors = new List<Actor>
                {
                    new Actor { FullName = "Marlon Brando" },
                    new Actor { FullName = "Al Pacino " },
                },
                Directors = new List<Director>
                {
                    new Director { FullName = "Francis Ford Coppola"}
                }
            });

            context.Movies.Add(new Movie
            {
                Title = "The Dark Knight",
                Year = 2008,
                Summary = "When a threat better known as the Joker emerges from his mysterious past and unleashes chaos on Gotham City, Batman must face the greatest of psychological and physical challenges to fight injustice.",
                Actors = new List<Actor>
                {
                    new Actor { FullName = "Marlon Brando" },
                    new Actor { FullName = "Al Pacino " },
                },
                Directors = new List<Director>
                {
                    new Director { FullName = "Christopher Nolan"}
                }
            });

            context.SaveChanges();
        }
    }
}
