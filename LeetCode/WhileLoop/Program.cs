﻿using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 6;

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
        }
    }
}
