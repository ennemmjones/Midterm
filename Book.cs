using System;
using System.Collections.Generic;
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


       

        public Book (string title, string author, string status, DateTime duedate)
        {

            Title = title;
            Author = author;
            Status = status;
            DueDate = duedate;


        }



        public class Library : Media
        {

            public static DateTime SetDueDate()
            {
                DateTime currentTime = DateTime.Now;
                DateTime returnDate = currentTime.AddDays(14);

                return returnDate;

             }













        }













    }
}
