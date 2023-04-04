using Helpers.cs.Models;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Helpers.cs
{
    public class Helpers
    {
        public static void SeeAllRegisteredMembers(List<Users> users)
        {
            foreach (Users user in users)
            {
                Models.Members.DisplayInfo(user);
            }
        }

        public static void SeeAllMoviesAvailable(List<Movies> movies)
        {
            Console.WriteLine("Here are the movies available for renting:");

            foreach (Movies movie in movies)
            {
                if (movie.IsAvailableForRenting)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        public static void SelectMovieFromList(List<Movies> movies)
        {
            Console.WriteLine("Here are the movies available for watching:");

            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].IsAvailableForRenting)
                    Console.WriteLine($"{i + 1}. {movies[i].Title}");
            }
        }

        public static void RentMovieFromList(List<Movies> movies, int number)
        {
            Console.WriteLine($"Are you sure you want to rent {movies[number - 1].Title}?(y/n)");
            string userRentMovie = Console.ReadLine();

            if(userRentMovie.ToLower() == "y")
            {
                Console.WriteLine($"You have successfully rented {movies[number - 1].Title}");

                foreach (Movies movie in movies)
                {
                    Models.Movies.SetPrice(movie);
                    break;
                }
            }
            else
            {
                Console.WriteLine("Got it! Come back anytime!");
            }
        }

        public static void SeeAllRentedMovies(List<Movies> movies)
        {
            Console.WriteLine("You have rented the movies:");

            foreach (Movies movie in movies)
            {
                if (movie.IsAvailableForRenting == false)
                {
                    Console.WriteLine($"{movie.Title}");
                    Models.Movies.SetPrice(movie);
                }
            }
        }
    }
}