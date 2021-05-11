using System;

namespace TeamNeptune
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Casino Royale", "Eon Productions", "PG-13");
            
            // Initialized with Second Constructor that takes in Two Parameters i.e Rating is "PG"
            Movie filmOne = new Movie("The Hobbit", "Warner Bros");
            Movie filmTwo = new Movie("Furious 7", "Universal Pictures");

            // Initialized with First Constructor that takes in Three Parameters
            Movie filmThree = new Movie("The Hunger Games", "Lionsgate Films", "R");
            Movie filmFour = new Movie("Gladiator", "DreamWorks Pictures", "PG");
            Movie filmFive = new Movie("Black Panther", "Walt Disney Studios", "PG-13");

            Movie[] movies = {filmOne, filmTwo, filmThree, filmFour, filmFive};
            Movie[] filmsWithPGRating = Movie.GetPg(movies);
            
            foreach (var film in filmsWithPGRating)
            {
                Console.WriteLine($"The Movie '{film.Title}' from {film.Studio} has {film.Rating} as its Rating");
            }
        }
    }
}
