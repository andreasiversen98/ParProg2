namespace MovieApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();



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

            movie.DisplayInfo();

        }
    }
}
