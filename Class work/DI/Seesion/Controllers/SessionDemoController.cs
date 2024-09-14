using Microsoft.AspNetCore.Mvc;
using Seesion.Models;

namespace Seesion.Controllers
{
    public class SessionDemoController : Controller
    {
        const string SessionName = "_Name";
        const string SessionAge = "_Age";
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString(SessionName) != null)
            {
                ViewBag.Name = HttpContext.Session.GetString(SessionName);
                ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
                ViewData["Message"] = "Asp.Net Core !!!.";
                return View();

            }
            return RedirectToAction("Create");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserLogin data) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpContext.Session.SetString(SessionName, data.Email);
                    HttpContext.Session.SetInt32(SessionAge, 20);
                }return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete()
        {
            HttpContext.Session.Remove(SessionName);
            return RedirectToAction("Create");
        }
        [ActionName("delete")]
        public IActionResult Deletedata()
        {
            HttpContext.Session.Remove(SessionName);
            return View(nameof(Index));
        }
        public IActionResult Display()
        {
            return View();  
        }
    }


}
