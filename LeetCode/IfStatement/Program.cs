using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a bamle but you are tall");
            }
            else if (isMale || isTall)
            {
                Console.WriteLine("You are either tall or a male");
            }
            else
            {
                Console.WriteLine("You are not male or not tall or both");
            }
        }
    }
}
