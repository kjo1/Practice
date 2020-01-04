using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("You", 3);
            SayHi("Me", 5);
            SayHi("John", 30);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
