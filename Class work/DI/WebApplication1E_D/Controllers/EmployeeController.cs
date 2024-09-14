using Microsoft.AspNetCore.Mvc;
using WebApplication1E_D.Service;

namespace WebApplication1E_D.Controllers
{
    public class EmployeeController:Controller
    {
        IEmployeeService service;
        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }
        public IActionResult Indext()
        {
            
            return View();
        }
    }
}
