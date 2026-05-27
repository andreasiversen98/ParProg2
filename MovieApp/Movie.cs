using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp
{

    internal class Movie
    {
        public string Title;
        public int Year;
        public string Director;
        public string Actors;
        public string Description;  

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
            Console.WriteLine($"Description: {Description}");
        }

        public void AddMovie()
        {
            Console.Write("Name: ");
            string title = Console.ReadLine();

        }
    }
}
