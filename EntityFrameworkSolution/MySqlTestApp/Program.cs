using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
namespace MySqlTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            PrintData();
        }

        private static void PrintData()
        {

        //Logic for fetching data from Mysql using EntityFrameworkCore
        //and MySql Connector
        //Using Object Relational Mapping Technique

        //Now Get all data from Mysql table and print

        using(var context = new LibraryContext())
        {
            var books=context.Book.Include(p=>p.Publisher);
            foreach(var book in books)
            {
                var data=new StringBuilder();
                data.AppendLine($"ISBN : {book.ISBN}");
                data.AppendLine($"Title: {book.Title}");
                data.AppendLine($"Publisher: {book.Publisher.Name}");
                Console.WriteLine(data.ToString());
            }
        }
    }
    }
}

