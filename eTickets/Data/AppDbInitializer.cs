using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        //public static void Seed(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        var context = serviceScope.ServiceProvider.GetServices<AppDbContext>();
        //        context.Database.EnsureCreated();

        //        //Cinema
        //        if (!context.Cinemas.Any())
        //        {
        //            context.Cinemas.AddRange(new List<Cinema>()
        //            {
        //                new Cinema()
        //                {
        //                    Name = "Cinema 1",
        //                    Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
        //                    Description = "This is the description of the first cinema"
        //                },
        //                new Cinema()
        //                {
        //                    Name = "Cinema 2",
        //                    Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
        //                    Description = "This is the description of the first cinema"
        //                },
        //                new Cinema()
        //                {
        //                    Name = "Cinema 3",
        //                    Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
        //                    Description = "This is the description of the first cinema"
        //                }
        //            });
        //            context.SaveChange();
        //        }
        //        //Actors
        //        if (!context.Actors.Any())
        //        {
        //            context.Actors.AddRange(new List<Actor>()
        //            {
        //                new Actor()
        //                {
        //                    FullName = "Actor 1",
        //                    Bio = "This is the bio of the second actor",
        //                    ProfilePictureURL = "http://dotnerhow.net/images/actors/actor-1.jpeg"
        //                },
        //                new Actor()
        //                {
        //                    FullName = "Actor 2",
        //                    Bio = "This is the bio of the second actor",
        //                    ProfilePictureURL = "http://dotnerhow.net/images/actors/actor-2.jpeg"
        //                },
        //                new Actor()
        //                {
        //                    FullName = "Actor 3",
        //                    Bio = "This is the bio of the second actor",
        //                    ProfilePictureURL = "http://dotnerhow.net/images/actors/actor-3.jpeg"
        //                }
        //            });
        //            context.SaveChange();
        //        }
        //        //Producers
        //        if (!context.Producers.Any())
        //        {
        //            context.Producers.AddRange(new List<Producer>()
        //            {
        //                new Producer()
        //                {
        //                    FullName = "Producer 1",
        //                    Bio = "This is the bio of the second actor",
        //                    ProfilePictureURL = "http://dotnerhow.net/images/actors/producer-1.jpeg"
        //                },
        //                new Producer()
        //                {
        //                    FullName = "Producer 2",
        //                    Bio = "This is the bio of the second actor",
        //                    ProfilePictureURL = "http://dotnerhow.net/images/actors/producer-2.jpeg"
        //                },
        //                new Producer()
        //                {
        //                    FullName = "Producer 3",
        //                    Bio = "This is the bio of the second actor",
        //                    ProfilePictureURL = "http://dotnerhow.net/images/actors/producer-3.jpeg"
        //                }
        //            });
        //            context.SaveChange();
        //        }
        //        //Movies
        //        if (!context.Movies.Any())
        //        {
        //            context.Movies.AddRange(new List<Movie>()
        //            {
        //                new Movie()
        //                {
        //                    Name = "Scoob",
        //                    Description = "This is the Scoob movie desciption",
        //                    Price = 39.50,
        //                    ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
        //                    StartDate = DateTime.Now.AddDays(-10),
        //                    EndDate = DateTime.Now.AddDays(-2),
        //                    CinemaId = 1,
        //                    ProducerId = 3,
        //                    MovieCategory = MovieCategory.Drama
        //                },
        //                new Movie()
        //                {
        //                    Name = "Cold Soles",
        //                    Description = "This is the Cold Soles movie desciption",
        //                    Price = 39.50,
        //                    ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
        //                    StartDate = DateTime.Now.AddDays(3),
        //                    EndDate = DateTime.Now.AddDays(20),
        //                    CinemaId = 1,
        //                    ProducerId = 5,
        //                    MovieCategory = MovieCategory.Comedy
        //                },
        //                new Movie()
        //                {
        //                    Name = "Sco",
        //                    Description = "This is the Sco movie desciption",
        //                    Price = 39.50,
        //                    ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
        //                    StartDate = DateTime.Now.AddDays(1),
        //                    EndDate = DateTime.Now.AddDays(2),
        //                    CinemaId = 1,
        //                    ProducerId = 2,
        //                    MovieCategory = MovieCategory.Documentory
        //                }
        //            });
        //            context.SaveChange();
        //        }
        //        //Actors and Movies
        //        if (!context.Actors_Movies.Any())
        //        {
        //            context.Actors_Movies.AddRange(new List<Actor_Movie>()
        //            {
        //                new Actor_Movie()
        //                {
        //                    ActorId = 3,
        //                    MovieId = 6
        //                },
        //                new Actor_Movie()
        //                {
        //                    ActorId = 4,
        //                    MovieId = 6
        //                },
        //                new Actor_Movie()
        //                {
        //                    ActorId = 5,
        //                    MovieId = 6
        //                }
        //            });
        //            context.SaveChange();
        //        }
        //    }
        //}
    }
}
