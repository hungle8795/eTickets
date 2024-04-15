using eTickets.Data.Enums;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AppDbContext>>()))
            {
                if (context == null || context.Cinemas == null || context.Producers == null
                     || context.Movies == null || context.Actor_Movies == null)
                {
                    throw new ArgumentNullException("Null AppDbContext");
                }

                // Look for any movies.
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        }
                    );
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the bio of the second actor",
                            ProfilePictureURL = "http://dotnerhow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the bio of the second actor",
                            ProfilePictureURL = "http://dotnerhow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the bio of the second actor",
                            ProfilePictureURL = "http://dotnerhow.net/images/actors/actor-3.jpeg"
                        }
                    );
                }

                // Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the bio of the second actor",
                            ProfilePictureURL = "http://dotnerhow.net/images/actors/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the bio of the second actor",
                            ProfilePictureURL = "http://dotnerhow.net/images/actors/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the bio of the second actor",
                            ProfilePictureURL = "http://dotnerhow.net/images/actors/producer-3.jpeg"
                        }
                    );
                    context.SaveChanges();
                }

                // Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie desciption",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10).ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(-2).ToUniversalTime(),
                            MovieCategory = MovieCategory.Drama,
                            CinemaId = 1,
                            ProducerId = 1
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie desciption",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(3).ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(20).ToUniversalTime(),
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId = 2,
                            ProducerId = 2
                        },
                        new Movie()
                        {
                            Name = "Sco",
                            Description = "This is the Sco movie desciption",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(1).ToUniversalTime(),
                            EndDate = DateTime.Now.AddDays(2).ToUniversalTime(),
                            MovieCategory = MovieCategory.Documentory,
                            CinemaId = 3,
                            ProducerId = 3
                        }
                    );
                    context.SaveChanges();
                }

                //Actors and Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
