using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.cs.Models
{
    public class Movies
    {
        public Movies()
        {

        }
        public Movies(string title, string description, int year, Genres genre, bool isAvailableForRenting, int price)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            IsAvailableForRenting = isAvailableForRenting;
            Price = price;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genres Genre { get; set; }
        public bool IsAvailableForRenting { get; set; }
        private int Price { get; set; }

        public static void SetPrice(Movies movie)
        {
            if (movie.Year < 2000)
            {
                movie.Price = new Random().Next(100, 201);
                Console.WriteLine($"The price for the movie is: {movie.Price}$$");
            }
            else if (movie.Year >= 2000 && movie.Year < 2010)
            {
                movie.Price = new Random().Next(200, 301);
                Console.WriteLine($"The price for the movie is {movie.Price}$$");
            }
            else
            {
                movie.Price = new Random().Next(300, 501);
                Console.WriteLine($"The price for the movie is {movie.Price}$$");
            }
        }
    }
}