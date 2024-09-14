using Microsoft.AspNetCore.Mvc;
using WebTest.Service;

namespace WebTest.Controllers
{
    public class EmployeeCotroller : Controller
    {
        IEmployee employee;
        public EmployeeCotroller(IEmployee employee)
        {
            this.employee = employee;
        }
       /* public IActionResult Index()
        {
            var a = employee.GetAll();
            return View(a);
        }
       */
        public IActionResult Detail(int id)
        {
            var b=employee.GetEmployee(id);
            return View(b);
        }
    }
}
