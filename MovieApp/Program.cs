using System.Reflection;

namespace MovieApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>();

            bool addingMovies = true;

            Console.WriteLine("Add movie to catalog:\n");

            while (addingMovies)
            {
                Console.Write("Movie Title: ");
                string title = Console.ReadLine();
                Console.Write("Movie Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Movie Director: ");
                string director = Console.ReadLine();
                Console.Write("Movie Description: ");
                string description = Console.ReadLine();
                Console.Write("Movie Actors: ");
                string actors = Console.ReadLine();

                Console.Clear();


                Movie movie = new Movie(title, year, director, actors, description);

                movies.Add(movie);

                Console.WriteLine("Would you like to add another movie? (yes/no):\n");
                string response = Console.ReadLine().ToLower();

                if (response != "yes" && response != "y")
                {
                    addingMovies = false;
                }

                Console.Clear();

                for (int i = 0; i < movies.Count; i++)
                {
                    movies[i].DisplayInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}

