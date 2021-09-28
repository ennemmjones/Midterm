using System;
using System.Collections.Generic;
using System.IO;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
           
                bool goOn = true;
                while (goOn == true)
                {







                    goOn = GetContinue(); // Calls Continue Method
                }


=======
            List<Book> ourLibrary = Library.MakeBooks();
            bool goOn = true;
            while (goOn == true)
            {
>>>>>>> f2432a3fe78b074291bb3b0aec503a18e4b5cdb4

                Console.WriteLine($"Select an option: (1) Display Library (2) Search by Author (3) Search by title (4) Check Out a book (5) Return a book");
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

    }
}
