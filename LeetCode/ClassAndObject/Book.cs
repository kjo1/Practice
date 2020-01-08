using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        { }

        public Book(string Title, string Author, int Pages)
        {
            title = Title;
            author = Author;
            pages = Pages;
        }
    }
}
