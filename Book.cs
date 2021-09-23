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




        public Book(string title, string author, string status, DateTime duedate)
        {

            Title = title;
            Author = author;
            Status = status;
            DueDate = duedate;


        }
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
                const string f = "Books.txt";
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
                    var split = s.Split('/');
                    book = new Book(split[0], split[1], split[2], SetDueDate());
                    library.Add(book);

                }
                return library;



            }


         public static List<Book> SearchbyAuthor(List<Book> library)
        {
            string userInput;
            Console.WriteLine("Which author would you like to search for?:" );

            userInput = Console.ReadLine().ToLower();

            List<Book> matchedAuthor = new List<Book>();
            

            for (int i = 0; i < library.Count; i++)
            {
                if (library[i].Author.Contains (userInput))
                {
                    matchedAuthor.Add(library[i]);
                }

                   
            }
            if (matchedAuthor.Count < 1)
            {

                Console.WriteLine("That search returned no results");
                
            }



            return matchedAuthor;
        }


        public static List<Book> SearchbyTitle(List<Book> library)
        {
            string userInput;
            Console.WriteLine("Which title would you like to search for?:");

            userInput = Console.ReadLine().ToLower();

            List<Book> matchedTitle = new List<Book>();


            for (int i = 0; i < library.Count; i++)
            {
                if (library[i].Author.Contains(userInput))
                {
                    matchedTitle.Add(library[i]);
                }


            }
            if (matchedTitle.Count < 1)
            {

                Console.WriteLine("That search returned no results");

            }



            return matchedTitle;
        }

























    }
}
