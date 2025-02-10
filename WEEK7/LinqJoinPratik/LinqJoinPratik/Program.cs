using LinqJoinPratik;
using System;

namespace PatikaWeek7.LinqJoinExercise
{
    public class Program
    {
        public static void Main (string[] args)
        {
            List<Book> books = new List<Book> ();
            books.Add ( new Book { AuthorId =1, Tittle="Kar", BookId=1});
            books.Add(new Book { AuthorId = 1, Tittle= "Istabul",BookId=2});
            books.Add(new Book { AuthorId = 2, Tittle = "10 Minutes 38 Seconds in This Strange World" ,BookId=3});
            books.Add(new Book { AuthorId= 3, Tittle="Beyoglu Rapsodisi",BookId=4});
            List<Author> authors = new List<Author> ();
            authors.Add(new Author { AuthorId = 1, Name = "Orhan Pamuk" });
            authors.Add(new Author { AuthorId = 2, Name = "Elif Safak" });
            authors.Add(new Author { AuthorId = 3, Name = "Ahmet Umit" });



            var query1 = from b in books
                         join a in authors on b.AuthorId equals a.AuthorId
                         select new
                         {
                             BookName=b.Tittle,
                             AuthorName=a.Name,
                         };
            foreach (var x in query1)
            {
                Console.WriteLine($"Kitabin Adi : {x.BookName}, " +
                                  $"Yazarin Adi : {x.AuthorName}");
            }
        }
    }
}