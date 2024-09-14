using Microsoft.AspNetCore.Mvc;
using Webapplication2.Models;
using Webapplication2.Service;

namespace Webapplication2.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployee emp;
        public EmployeeController(IEmployee employee)
        {
            this.emp = employee;
        }
        public ActionResult Index()
        {
            var a = emp.GetAll();
            return View(a);
        }


        public IActionResult Details(int id)
        {
            var b = emp.GetEmployee(id);
            ViewBag.Head = "Employee details are";
            return View(b);
        }

        public ActionResult Create()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Employee employee)
        {

            if (ModelState.IsValid)
            {
                var model = emp.Add(employee);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var b = emp.GetEmployee(id);

            return View(b);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                var a = emp.Update(employee);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
        public ActionResult Delete(int id)
        {
               var b = emp.GetEmployee(id);
            return View(b);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult Deletedata(int id)
        {
            var b = emp.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
