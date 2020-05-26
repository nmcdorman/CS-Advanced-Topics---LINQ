using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_Advanced_Topics___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // want to display books cheaper than $10
            //  old
            //var cheapBooks = new List<Book>();
            //foreach ( var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //foreach (var book in cheapBooks)            
            //    Console.WriteLine(book.Title + " " + book.Price);

            //  new
            // LINQ Extension Methods
            //var cheapBooks2 = books.Where(b => b.Price < 10);
            //foreach (var book in cheapBooks2)
            //    Console.WriteLine(book.Title + " " + book.Price);

            //// order by
            //var cheaperBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);
            //foreach (var book in books)
            //    Console.WriteLine(book);

            // ^ should be layed out differently            
            //var cheaperBooks2 = books
            //                        .Where(b => b.Price < 10)
            //                        .OrderBy(b => b.Title)
            //                        .Select(b => b.Title);

            // LINQ Query Operators
            //var cheapBooks =
            //    from b in books
            //    where b.Price < 10
            //    orderby b.Title
            //    select b;

            //var book = books.Single(b => b.Title == "ASP.NET MVC");
            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVCd");
            //var book = books.First(b => b.Title == "C# Advanced Topics");
            //var book = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            //var pagedBooks = books.Skip(2).Take(3);
            //var pagedBooks = books.Count();
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var sumPrice = books.Sum(b => b.Price);

            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(sumPrice);


            //foreach (var book in pagedBooks)
            //    Console.WriteLine(book.Title + " " + book.Price);
        }
    }
}
