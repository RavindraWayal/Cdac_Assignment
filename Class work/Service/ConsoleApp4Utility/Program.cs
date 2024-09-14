using ConsoleApp4Utility.models;
using ConsoleApp4Utility.Service;

namespace ConsoleApp4Utility
{
    internal class Program
        
    {
        static Program()
        {
            Console.WriteLine("-----------------Entity Framework-----------------");
        }
        static void Main(string[] args)
        {
           Servicebook servicebook = new Servicebook();

            var b = servicebook.Display();

            foreach (var item in b)
            {
                Console.WriteLine("Title={0}                    Author name={1}                    Author lastname={2}                    BookId={3} ",item?.Title, item?.Author?.FirstName,  item?.Author?.LastName, item?.BookId);

            }

            /*var Book = new Book
            {
                Title = "Test",
                Author = new Author
                {
                    FirstName = "vidya",
                    LastName = "Nidhi"

                }
            };
            servicebook.AddBook(Book);
            var book = new Book
            {
                Title = "DSA",
                Author = new Author
                {
                    FirstName = "Rohan",
                    LastName = "expert"
                }
            };
            servicebook.AddBook(book);
            */
            /*
            var Book1 = new Book
            {
                Title = "Adventure",
                BookId = 1,
                AuthorId=2
            };
            servicebook.UpdateBook( Book1);
            */
            /*
            var book3 = new Book
            {
                Title = "Bhagwatgeeta",
                BookId = 2,
                AuthorId = 3
            };
            servicebook.Changes(book3);
            */
            //servicebook.add1();
            servicebook.Addmultiple();
            
        }
    }
}
