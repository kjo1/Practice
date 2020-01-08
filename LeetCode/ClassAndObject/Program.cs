using System;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Challenge", "Kanghyun Jo", 333);
            Book book2 = new Book("Happiness", "Kanghyun Jo", 777);
            Book book3 = new Book();

            book1.title = "Challenged 2";

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);
        }
    }
}
