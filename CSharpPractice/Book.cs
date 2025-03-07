/* Constructor Overloading in a Library System**

Implement a `Book` class with three different constructors: (1) Default constructor, (2) 
Constructor with `Title` and `Author`, (3) Constructor with `Title`, `Author`, and `ISBN`. 
Ensure each constructor initializes properties correctly. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Book
    {
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public Book()
        {
            isbn = "unknown";
            title = "unknown";
            author = "unknown";
        }
        public Book(string Title, string Author)
        {
            title = Title;
            author = Author;
        }
        public Book(string Isbn, string Title, string Author)
        {
            isbn = Isbn;
            title = Title;
            author = Author;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Isbn : {isbn}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Author : {author}");
        }
    }
}
