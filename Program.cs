using System;
using System.Collections.Generic;
using System.IO;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> ourLibrary = Library.MakeBooks();
            foreach (Book b in ourLibrary)
            { 
                Console.WriteLine($"{ b.Author}, { b.Title}, {b.Status}, {b.DueDate} "); 
            }

        }
        
    }
}
