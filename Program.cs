﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Book> ourLibrary = Library.MakeBooks();
            bool goOn = true;
            while (goOn == true)
            {


                Console.WriteLine($"Select an option:\n (1) Display Library\n (2) Search by Author\n (3) Search by title\n (4) Check Out a book\n (5) Return a book\n (6) Add book to Library");
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Library.DisplayInfo(ourLibrary);
                            break;
                        }
                    case "2":
                        {
                            Library.SearchbyAuthor(ourLibrary);
                            break;
                        }
                    case "3":
                        {
                            Library.SearchbyTitle(ourLibrary);
                            break;
                        }
                    case "4":
                        {
                            Library.CheckOut(ourLibrary);
                            break;
                        }
                    case "5":
                        {
                            Library.ReturnBook(ourLibrary);
                            break;
                        }
                    case "6":
                        {
                            var book = Library.AddBook(ourLibrary);
                            ourLibrary.Add(book);
                            break;
                        }


                    default:
                        {
                            Console.WriteLine("Please select a valid Choice");
                            break;
                        }
                }
                



               
                goOn = GetContinue(); // Calls Continue Method
            }
            Library.WriteToFile(ourLibrary);



            //List<Book> ourLibrary = Library.MakeBooks();
            //Console.WriteLine($"{"TITLE",-40} {"AUTHOR",-25} {"STATUS",-12} {"DUE DATE"}");
            //foreach (Book b in ourLibrary)
            //{
            //    if (b.Status == "Checked Out")
            //    {
            //        Console.WriteLine($"{b.Title, -40} {b.Author, -25} {b.Status, -12} {b.DueDate} ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{b.Title, -40} {b.Author, -25} {b.Status, -12} ");

            //    }

            //}
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

            

            //Library.WriteToFile(ourLibrary);
        }
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to return back to our library menu? yes or no");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                return true;
            }
            else if (answer == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");

                return GetContinue();
            }
        }

    }
}
