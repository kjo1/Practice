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
        }
    }
}
