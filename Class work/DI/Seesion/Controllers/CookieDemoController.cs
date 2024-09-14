using Microsoft.AspNetCore.Mvc;
using Seesion.Models;

namespace Seesion.Controllers
{
    [Route("Controller/Action")]
    public class CookieDemoController : Controller
    {
        [Route("inbox")]
        public IActionResult Index()
        {
            var CookieValue = Request.Cookies["Ukey"]?.ToString();
            ViewBag.CookieValue = CookieValue;
            return View(nameof(Index));
        }
        public IActionResult Create()
        {
            UserLogin obj = null;
            var CookieValue = Request.Cookies["Ukey"]?.ToString();
            if (CookieValue != null)
            {
                obj = new UserLogin();
                obj.Email = CookieValue;
            }

            return View(obj);

          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserLogin Userdata)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Userdata.Remember == true)
                    {
                        CookieOptions options = new CookieOptions();
                        options.Expires = DateTime.Now.AddDays(7);
                        Response.Cookies.Append("Ukey", Userdata.Email, options);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
