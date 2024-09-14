using Microsoft.AspNetCore.Mvc;
using WebappMVC1.Models;

namespace WebappMVC1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Details()
        {
            Book b2 = new Book
            {
                BookId = 1,
                Title = "C### .Net"

            };
            ViewBag.Heading = "COmputer Book2";
            return View(b2);
        }
    }
}
