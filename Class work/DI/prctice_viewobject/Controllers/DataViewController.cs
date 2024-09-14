using Microsoft.AspNetCore.Mvc;
using prctice_viewobject.Models;

namespace prctice_viewobject.Controllers
{
    public class DataViewController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Akshay";
            Employee e = new Employee
            {
                EmpId = 1,
                EmpName = "Name",
                Designation = "Accountant",
                Salary = 20000
            };
            ViewBag.Employee = e;
            string[] fuits = { "Apple", "Banana", "Kaju" };
            ViewBag.Fruits= fuits;
            var sports = new List<string>
            {
                "Cricket",
                "Football",
                "hockey",
                "Tennis",
                "BasketBall"
            };
            ViewBag.Sports= sports;
            return View();
        }
    }
}
