using ConsoleApp4Utility.models;
using ConsoleApp4Utility.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4Utility.Service
{
    internal class Servicebook
    {
        private readonly SampleContext db;
        public  Servicebook()
        {
            db=new SampleContext();
        }
        public IEnumerable<Book> Display()
        {
            return db.Books.Include((a) => a.Author).ToList<Book>();
        }
        public void AddBook(Book obj)
        {
            db.Books.Add(obj);
            db.SaveChanges();
        }
        public void UpdateBook(Book obj)
        {
            SampleContext db = new SampleContext();
            db.Update(obj);
            db.SaveChanges();
        }
         public void DeleteBook(int id) 
        {                           
            Book book= db.Books.FirstOrDefault(x=>x.BookId==id);
            if(book!=null)
            {
                db.Remove(book);
                db.SaveChanges();
            }
        }
        public void Changes(Book book)
        {
            SampleContext db= new SampleContext();
            db.Entry(book).State = EntityState.Modified;
            db.SaveChanges();
            
        }
        public void add1()
        {
            var author = new Author
            {
                FirstName = "Willim",
                LastName = "Shakespear",
                Books = new List<Book>
                {
                    new Book {Title="Hemlet"},
                    new Book { Title = "Othello" },
                    new Book { Title="MacBeth"}
                }
            };
            db.Add(author);
            db.SaveChanges();
            
        }
        public void Addmultiple()
        {
            var author = new Author { FirstName = "Stephen", LastName = "King" };
            var books = new List<Book>
            {
                new Book{Title="It",Author=author},
                new Book{Title="Carrie",Author =author},
                new Book{Title="Mistery",Author=author}
            };
            db.Books.AddRange(books);
            db.SaveChanges();
        }

    }
}
