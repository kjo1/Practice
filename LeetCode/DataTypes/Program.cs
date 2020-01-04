using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hello World";
            // single character for char inside ''
            char grade = 'A';
            int age = 20; //-20
            double gpa = 3.2; //3.0 need to include .0
            bool isMale = true;

            Console.WriteLine("Hello\nWorld");      // \" to input qutation mark    

            // string methods
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Hello"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("W"));
            Console.WriteLine(phrase.Substring(6, 2));

            Console.WriteLine(4 + 2 * 3); // 10
            Console.WriteLine((4 + 2) * 3); // 18
            Console.WriteLine(5 / 2); // 2 int int int back
            Console.WriteLine(5 / 2.0); // 2.5 int decimal decimal back

            int num = 6;
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40)); // 40
            Console.WriteLine(Math.Pow(3.8, 2)); // 14.44
            Console.WriteLine(Math.Sqrt(36)); // 6
            Console.WriteLine(Math.Max(4, 30)); // 30
            Console.WriteLine(Math.Min(4, 30)); // 4
            Console.WriteLine(Math.Round(3.2)); // 3
            Console.WriteLine(Math.Round(3.6)); // 4

        }
    }
}
