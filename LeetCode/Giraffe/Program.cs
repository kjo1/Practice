using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "You";
            int characterAge;
            characterAge = 20;

            Console.WriteLine("Hello " + characterName + "!");
            Console.WriteLine("You are " + characterAge + " years old!");

            characterName = "me";
            Console.WriteLine("You really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}
