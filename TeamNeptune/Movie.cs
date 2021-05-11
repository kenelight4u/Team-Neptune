using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamNeptune
{
    public class Movie
    {
        // The Three Variables
        public string Title { get; set; }

        public string Studio{ get; set; }

        public string Rating { get; set; }

        // The First Constructor
        public Movie(string title, string studio, string rating)
        {
            this.Title = title;

            this.Studio = studio;

            this.Rating = rating;
        }

        // The Second Constructor
        public Movie(string title, string studio)
        {
            this.Title = title;

            this.Studio = studio;

            this.Rating = "PG";
        }

        // The Method
        public static Movie[] GetPg(Movie[] movies)
        { 
            List<Movie> movieWithPgRating = new List<Movie>();

            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating == "PG")
                {
                    movieWithPgRating.Add(movies[i]);
                }
            }

            return movieWithPgRating.ToArray();
        }
    }
}