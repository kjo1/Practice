using System;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR
            shrek.Rating = "RRR";
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);
        }
    }
}
