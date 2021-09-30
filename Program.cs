using System;
using System.Collections.Generic;
using System.IO;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Grand Circus Public Library");

            List<Book> ourLibrary = Library.MakeBooks();
            bool goOn = true;
            while (goOn == true)
            {
                

                Console.WriteLine($"Select an option:\n (1) Display Library\n (2) Search by Author\n (3) Search by title\n (4) Check Out a book\n (5) Return a book\n (6) Add book to Library\n (7) Exit the Library");
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
                    case "7":
                        {
                            goOn = GetContinue();
                            break;
                        }


                    default:
                        {
                            Console.WriteLine("Please select a valid Choice");
                            break;
                        }
                }
                



               
                
            }
            Library.WriteToFile(ourLibrary);


        }
        public static bool GetContinue()
        {
<<<<<<< HEAD
            Console.WriteLine("Would you like to return back to our library menu or exit our library? ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "return")
            {
                return true;
            }
            else if (answer == "exit")
=======
            Console.WriteLine("Do you want to exit the Library? yes or no");
            string answer = Console.ReadLine().ToLower();

            if (answer == "no")
            {
                return true;
            }
            else if (answer == "yes")
>>>>>>> 0fbe604724608a7bcbab76f2037f39f9db10d57f
            {
                Console.WriteLine("Thanks for visting, Goodbye");
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
