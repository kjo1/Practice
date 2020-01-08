using System;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Challenge";
            book1.author = "Kanghyun Jo";
            book1.pages = 333;

            Book book2 = new Book();
            book2.title = "Happiness";
            book2.author = "Kanghyun Jo";
            book2.pages = 777;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);

            Console.WriteLine("Hello World!");
        }
    }
}
