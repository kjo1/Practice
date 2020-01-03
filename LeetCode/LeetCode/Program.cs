using System;
using System.Diagnostics;

namespace LeetCode
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            const int _max = 10000000;
            Console.WriteLine(StringHelper.ReverseString("Hello World"));
            Console.WriteLine(StringHelper.ReverseStringDirect("Hello World"));


            // Version 1: reverse with TocharArray.
            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                sum += StringHelper.ReverseString("Hello World").Length;
            }
            s1.Stop();

            // Version 2: reverse with iteration.
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                sum += StringHelper.ReverseStringDirect("Hello World").Length;
            }
            s2.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds);
            Console.WriteLine(s2.Elapsed.TotalMilliseconds);
            
            // somehow Reverse String Direct took longer??
        }
    }
}
