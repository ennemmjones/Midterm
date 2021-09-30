using System;
using System.Collections.Generic;
using System.IO;

namespace Midterm
{


    public abstract class Media
    {

    }


    public class Book : Media
    {
        

        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }


        //public string titleInput { get; set; }
        //public string authorName { get; set; }




        public Book(string title, string author, string status, DateTime duedate = default(DateTime))
        {

            Title = title;
            Author = author;
            Status = status;
            DueDate = duedate;


        }
        //Constructor added so AddBook Method works
        //public Book(string titleInput, string authorName)
        //{
        //    this.titleInput = titleInput;
        //    this.authorName = authorName;
        //}
    }


    public class Library : Media
    {

        public static DateTime SetDueDate()
        {
            DateTime currentTime = DateTime.Now;
            DateTime returnDate = currentTime.AddDays(14);

            return returnDate;

        }

        public static List<Book> MakeBooks()
        {

            const string f = @"../../../Books.txt";

            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            Book book;
            List<Book> library = new List<Book>();
            foreach (string s in lines)
            {
                var split = s.Split('|');
                book = new Book(split[0], split[1], split[2], Convert.ToDateTime(split[3]));
                library.Add(book);

            }
            return library;

        }


        public static void SearchbyAuthor(List<Book> library)
        {
            string userInput;
            Console.WriteLine("Which author would you like to search for?:");

            userInput = Console.ReadLine().ToLower();

            List<Book> matchedAuthor = new List<Book>();


            for (int i = 0; i < library.Count; i++)
            {
                if (library[i].Author.ToLower().Contains(userInput))
                {
                    matchedAuthor.Add(library[i]);
                }

            }
            if (matchedAuthor.Count < 1)
            {

                Console.WriteLine("That search returned no results");

            }

            foreach (Book b in matchedAuthor)
            {
                Console.WriteLine($"{b.Title,-40} {b.Author,-20} ");
            }
        }


        public static void SearchbyTitle(List<Book> library)
        {
            string userInput;
            Console.WriteLine("Which title would you like to search for?:");

            userInput = Console.ReadLine().ToLower();

            List<Book> matchedTitle = new List<Book>();


            for (int i = 0; i < library.Count; i++)
            {
                if (library[i].Title.ToLower().Contains(userInput))
                {
                    matchedTitle.Add(library[i]);
                }

            }
            if (matchedTitle.Count < 1)
            {

                Console.WriteLine("That search returned no results");

            }

            foreach (Book b in matchedTitle)
            {
                Console.WriteLine($"{b.Title,-40} {b.Author,-20}");
            }
        }

        public static void WriteToFile(List<Book> library)
        {
            const string f = @"../../../Books.txt";
            using (StreamWriter w = new StreamWriter(f))
            {
                foreach (Book b in library)
                {
                    w.WriteLine($"{b.Title}|{b.Author}|{b.Status}|{b.DueDate}");
                }
            }


        }

        public static void CheckOut(List<Book> library)
        {
            // Display book title with Number
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine($"[{i}]\t- {library[i].Title}");
            }

            // Get user input
            Console.Write("Select the number of the book you would like to check out: ");
            string userInput = Console.ReadLine();

            // Validate input
            var testInput = Int32.TryParse(userInput, out int index);
            if (!testInput || index > library.Count)
            {
                Console.WriteLine("Not a valid selection");
                return;
            }

            Book book = library[index];

            // Check book's current status
            if (book.Status == "Checked Out")
            {
                Console.WriteLine($"That book is already checked out. It should be back by {book.DueDate}.");
            }
            // Check out book (change status, set due date)
            else
            {
                book.Status = "Checked Out";
                book.DueDate = SetDueDate();
                Console.WriteLine($"{book.Title} is due back on {book.DueDate}.");
            }

        }

        public static void ReturnBook(List<Book> library)
        {
            // Display book title with Number
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine($"[{i}]\t-  {library[i].Title}");
            }

            // Get user input
            Console.Write("Select the number of the book you would like to return: ");
            string userInput = Console.ReadLine();

            // Validate input
            var testInput = Int32.TryParse(userInput, out int index);
            if (!testInput || index > library.Count)
            {
                Console.WriteLine("Not a valid selection");
                return;
            }

            Book book = library[index];

            // Return book (change status, reset date)
            if (book.Status == "Checked Out")
            {
                book.Status = "On Shelf";
                book.DueDate = DateTime.MinValue;
                Console.WriteLine($"{book.Title} has been returned");
            }
            else
            {
                Console.WriteLine($"That book is already on the shelf.");
            }

        }

        public static void DisplayInfo(List<Book> library)
        {
            Console.WriteLine($"{"TITLE",-40} {"AUTHOR",-25} {"STATUS",-12} {"DUE DATE"}");
            foreach (Book b in library)
            {
                if (b.Status == "Checked Out")
                {
                    Console.WriteLine($"{b.Title,-40} {b.Author,-25} {b.Status,-12} {b.DueDate} ");
                }
                else
                {
                    Console.WriteLine($"{b.Title,-40} {b.Author,-25} {b.Status,-12} ");

                }

            }


        }


        public static void AddBook(List<Book> library)
        {
            string titleInput;
            string authorName;
            
            Console.WriteLine("Please enter the name of book you would like to add to our Library");

            titleInput = Console.ReadLine();

            Console.WriteLine("Now enter the name of the author for the book you would like to add to our Library");

            authorName = Console.ReadLine();



            List<Book> addedBook = new List<Book>();

            for (int i = 0; i < library.Count; i++)
            {
                

                addedBook.Add(new Book(titleInput, authorName, "On Shelf", default(DateTime)));
            }

            Console.WriteLine($"The book {titleInput} by {authorName} has been added to the library");







            //Writes to book file
            //const string k = @"../../../Books.txt";
             //using (StreamWriter w = new StreamWriter(k))
           // {
           //     foreach (Book b in library)
            //  {
             //     w.WriteLine($"{b.Title}|{b.Author}|{b.Status}|{b.DueDate}");
            //  }
            // }



        }
    }
}