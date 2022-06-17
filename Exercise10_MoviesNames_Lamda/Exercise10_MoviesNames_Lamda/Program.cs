using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10_MoviesNames_Lamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie() { Id = 1001, Name = "Spider-Man" },
                new Movie() { Id = 1002, Name = "Fast & Furious" },
                new Movie() { Id = 1003, Name = "The Lord of the Rings" }
            };

            List<MovieList> moviesList = new List<MovieList>()
            {
                new MovieList() { Code = 1, MovieId = 1001, MovieSequels = new List<string>()
                {
                    "The Amazing Spider-Man","The Amazing Spider-Man 2",
                    "Spider-Man: Homecoming","Spider-Man: Into the Spider - Verse",
                    "Spider-Man: Far From Home", "Spider-Man: No Way Home",
                    "Spider-Man: Across the Spider-Verse"}
                },
                new MovieList() {Code = 2, MovieId = 1002, MovieSequels = new List<string>()
                {
                    "The Fast and the Furious (2001)","Fast 2 Furious (2003)",
                    "The Fast and the Furious: Tokyo Drift (2006)","Fast & Furious (2009)",
                    " Fast Five (2011)","Fast & Furious 6 (2013)"," Furious 7 (2015)",
                    "The Fate of the Furious (2017)","F9 (2021)"}
                },
                new MovieList(){Code = 3, MovieId = 1003, MovieSequels = new List<string>()
                    {
                        "The Fellowship of the Ring","The Two Towers",
                        "The Return of the King"
                    }
                }
            };
            var list = movies.Join(moviesList, x => x.Id, y => y.MovieId,
                (x, y) => new
                {
                    Name = x.Name,
                    MovieSequels = y.MovieSequels
                });
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name}:");
                Console.ForegroundColor= ConsoleColor.Cyan;
                foreach (var film in item.MovieSequels)
                {
                    Console.WriteLine(film);
                }
                Console.ResetColor();
                Console.WriteLine("============================================");
            }

            Console.ReadKey();
        }
    }
}
