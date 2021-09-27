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
            Console.WriteLine($"{"TITLE",-40} {"AUTHOR",-25} {"STATUS",-12} {"DUE DATE"}");
            foreach (Book b in ourLibrary)
            {
                if (b.Status == "Checked Out")
                {
                    Console.WriteLine($"{b.Title, -40} {b.Author, -25} {b.Status, -12} {b.DueDate} ");
                }
                else
                {
                    Console.WriteLine($"{b.Title, -40} {b.Author, -25} {b.Status, -12} ");

                }

            }
            //var authorSearch = Library.SearchbyAuthor(ourLibrary);
            //foreach (Book b in authorSearch)
            //{
            //    Console.WriteLine($"{b.Title}, {b.Author}, {b.Status}, {b.DueDate} ");
            //}

            //var titleSearch = Library.SearchbyTitle(ourLibrary);
            //foreach (Book b in titleSearch)
            //{               
            //    Console.WriteLine($"{b.Title}, {b.Author}, {b.Status}, {b.DueDate} ");
            //}

            //Library.CheckOut(ourLibrary);
            //Library.ReturnBook(ourLibrary);

            Library.WriteToFile(ourLibrary);
        }
        
    }
}
