﻿using System;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(cube(5));

            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
