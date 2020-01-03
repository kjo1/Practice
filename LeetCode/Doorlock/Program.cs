using System;

namespace Doorlock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 2, 0, 2, 0 };
            int[] userInput = new int[4];

            while (true)
            {
                Console.WriteLine("Enter the first number");
                userInput[0] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                userInput[1] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the third number");
                userInput[2] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the fourth number");
                userInput[3] = int.Parse(Console.ReadLine());

                if (userInput[0] == passcodeNumbers[0]
                    && userInput[1] == passcodeNumbers[1]
                    && userInput[2] == passcodeNumbers[2]
                    && userInput[3] == passcodeNumbers[3])
                {
                    Console.WriteLine("\nDoor is unlocked");
                    break;
                }
                else
                {
                    Console.WriteLine("\nThe numbers are incorrect\n Please try again\n");
                }
            }
        }
    }
}
