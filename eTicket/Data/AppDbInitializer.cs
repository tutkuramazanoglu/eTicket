using eTicket.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eTicket.Data
{
    public static class AppDbInitializer
    {
        public static void Seed(this AppDbContext context)
        {
            if (!context.Cinemas.Any())
            {
                context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            CinemaName = "Cinema 1",
                            LogoURL = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            CinemaDescription = "This is the description of the first cinema"
                        },
                        new Cinema()
                            {
                                CinemaName = "Cinema 2",
                                LogoURL = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                                CinemaDescription = "This is the description of the first cinema"
                            },
                        new Cinema()
                            {
                                CinemaName = "Cinema 3",
                                LogoURL = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                                CinemaDescription = "This is the description of the first cinema"
                            },
                        new Cinema()
                            {
                                CinemaName = "Cinema 4",
                                LogoURL = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                                CinemaDescription = "This is the description of the first cinema"
                            },
                        new Cinema()
                            {
                                CinemaName = "Cinema 5",
                                LogoURL = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                                CinemaDescription = "This is the description of the first cinema"
                            },
                     });
                context.SaveChanges();
            }
            //Producer
            if (!context.Producers.Any())
            {
                context.Producers.AddRange(new List<Producer>()
                        {
                            new Producer()
                            {
                                ProducerFullName = "Producer 1",
                                ProducerBio = "This is the Bio of the first actor",
                                ProducerProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                            },
                            new Producer()
                            {
                                ProducerFullName = "Producer 2",
                                ProducerBio = "This is the Bio of the second actor",
                                ProducerProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                            },
                            new Producer()
                            {
                                ProducerFullName = "Producer 3",
                                ProducerBio = "This is the Bio of the second actor",
                                ProducerProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                            },
                            new Producer()
                            {
                                ProducerFullName = "Producer 4",
                                ProducerBio = "This is the Bio of the second actor",
                                ProducerProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                            },
                            new Producer()
                            {
                                ProducerFullName = "Producer 5",
                                ProducerBio = "This is the Bio of the second actor",
                                ProducerProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                            }
                        });
                context.SaveChanges();
            }
            //Actor
            if (!context.Actors.Any())
            {
                context.Actors.AddRange(new List<Actor>()
                        {
                            new Actor()
                            {
                                FullName = "Actor 1",
                                Bio = "This is the Bio of the first actor",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                            },
                            new Actor()
                            {
                                FullName = "Actor 2",
                                Bio = "This is the Bio of the second actor",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                            },
                            new Actor()
                            {
                                FullName = "Actor 3",
                                Bio = "This is the Bio of the second actor",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                            },
                            new Actor()
                            {
                                FullName = "Actor 4",
                                Bio = "This is the Bio of the second actor",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                            },
                            new Actor()
                            {
                                FullName = "Actor 5",
                                Bio = "This is the Bio of the second actor",
                                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                            }
                        });
                context.SaveChanges();
            }
            //Movie
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(new List<Movie>()
                        {
                            new Movie()
                            {
                                MovieName = "Life",
                                MovieDesc = "This is the Life movie description",
                                MoviePrice = 39.50,
                                MovieURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                                MoiveStartDate = DateTime.Now.AddDays(-10),
                                MovieEndDate = DateTime.Now.AddDays(10),
                                CinemaID = 3,
                                ProducerID = 3,
                                MovieCategory = MovieCategory.Documentary
                            },
                            new Movie()
                            {
                                MovieName = "The Shawshank Redemption",
                                MovieDesc = "This is the Shawshank Redemption description",
                                MoviePrice = 29.50,
                                MovieURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                                MoiveStartDate = DateTime.Now,
                                MovieEndDate = DateTime.Now.AddDays(3),
                                CinemaID = 1,
                                ProducerID = 1,
                                MovieCategory = MovieCategory.Action
                            },
                            new Movie()
                            {
                                MovieName = "Ghost",
                                MovieDesc = "This is the Ghost movie description",
                                MoviePrice = 39.50,
                                MovieURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                                MoiveStartDate = DateTime.Now,
                                MovieEndDate = DateTime.Now.AddDays(7),
                                CinemaID = 4,
                                ProducerID = 4,
                                MovieCategory = MovieCategory.Drama
                            },
                            new Movie()
                            {
                                MovieName = "Race",
                                MovieDesc = "This is the Race movie description",
                                MoviePrice = 39.50,
                                MovieURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                                MoiveStartDate = DateTime.Now.AddDays(-10),
                                MovieEndDate = DateTime.Now.AddDays(-5),
                                CinemaID = 1,
                                ProducerID = 2,
                                MovieCategory = MovieCategory.Documentary
                            },
                            new Movie()
                            {
                                MovieName = "Scoob",
                                MovieDesc = "This is the Scoob movie description",
                                MoviePrice = 39.50,
                                MovieURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                                MoiveStartDate = DateTime.Now.AddDays(-10),
                                MovieEndDate = DateTime.Now.AddDays(-2),
                                CinemaID = 1,
                                ProducerID = 3,
                                MovieCategory = MovieCategory.Comedy
                            },
                            new Movie()
                            {
                                MovieName = "Cold Soles",
                                MovieDesc = "This is the Cold Soles movie description",
                                MoviePrice = 39.50,
                                MovieURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                                MoiveStartDate = DateTime.Now.AddDays(3),
                                MovieEndDate = DateTime.Now.AddDays(20),
                                CinemaID = 1,
                                ProducerID = 5,
                                MovieCategory = MovieCategory.Drama
                            }
                        });
                context.SaveChanges();
            }
            
            
            //Actor and Movie
            if (!context.Actors_Movies.Any())
            {
                context.Actors_Movies.AddRange(new List<Actor_Movie>()
                        {
                            new Actor_Movie()
                            {
                                ActorID = 1,
                                MovieID = 1
                            },
                            new Actor_Movie()
                            {
                                ActorID = 3,
                                MovieID = 1
                            },

                             new Actor_Movie()
                            {
                                ActorID = 1,
                                MovieID = 2
                            },
                             new Actor_Movie()
                            {
                                ActorID = 4,
                                MovieID = 2
                            },

                            new Actor_Movie()
                            {
                                ActorID = 1,
                                MovieID = 3
                            },
                            new Actor_Movie()
                            {
                                ActorID = 2,
                                MovieID = 3
                            },
                            new Actor_Movie()
                            {
                                ActorID = 5,
                                MovieID = 3
                            },


                            new Actor_Movie()
                            {
                                ActorID = 2,
                                MovieID = 4
                            },
                            new Actor_Movie()
                            {
                                ActorID = 3,
                                MovieID = 4
                            },
                            new Actor_Movie()
                            {
                                ActorID = 4,
                                MovieID = 4
                            },


                            new Actor_Movie()
                            {
                                ActorID = 2,
                                MovieID = 5
                            },
                            new Actor_Movie()
                            {
                                ActorID = 3,
                                MovieID = 5
                            },
                            new Actor_Movie()
                            {
                                ActorID = 4,
                                MovieID = 5
                            },
                            new Actor_Movie()
                            {
                                ActorID = 5,
                                MovieID = 5
                            },


                            new Actor_Movie()
                            {
                                ActorID = 3,
                                MovieID = 6
                            },
                            new Actor_Movie()
                            {
                                ActorID = 4,
                                MovieID = 6
                            },
                            new Actor_Movie()
                            {
                                ActorID = 5,
                                MovieID = 6
                            },
                        });
                context.SaveChanges();
            }
        }

    }
}

