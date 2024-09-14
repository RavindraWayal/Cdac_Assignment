using Microsoft.AspNetCore.Mvc;

namespace WebappMVC1.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
