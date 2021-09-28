using System;
using System.Collections.Generic;
using System.IO;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
           
                bool goOn = true;
                while (goOn == true)
                {







                    goOn = GetContinue(); // Calls Continue Method
                }



                public static bool GetContinue()
                    {
                        Console.WriteLine("Would you like to continue? y/n");
                        string answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            return true;
                        }
                        else if (answer == "n")
                        {
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that, please try again");

                            return GetContinue();
                        }
                    }


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
