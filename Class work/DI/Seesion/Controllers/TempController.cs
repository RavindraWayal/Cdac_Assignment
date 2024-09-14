using Microsoft.AspNetCore.Mvc;

namespace Seesion.Controllers
{
    public class TempController : Controller
    {
        public IActionResult Index()
        {
            TempData["Message"] = "Hello from Tempdatacontroller";
            TempData["Process_Message"] = "Process Completed but keep data";
            return View();
        }
    }
}
