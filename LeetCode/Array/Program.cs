using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 20, 18, 5, 22, 2, 45 };
            string[] colors = new string[5];
            colors[0] = "Green";
            colors[1] = "Blue";

            Console.WriteLine(colors[1]);

            luckyNumbers[1] = 33;

            Console.WriteLine(luckyNumbers[1]);
        }
    }
}
