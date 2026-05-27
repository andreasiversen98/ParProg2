using MovieApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp
{

    internal class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Description { get; set; }



        public Movie(string title, int year, string director, string actors, string description)
        {
            Title = title;
            Year = year;
            Director = director;
            Actors = actors;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Actors: {Actors}");
            Console.WriteLine($"Description: {Description}\n");
        }
    }
}