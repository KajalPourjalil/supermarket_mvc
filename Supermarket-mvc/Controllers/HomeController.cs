using Microsoft.AspNetCore.Mvc;

namespace supermarket_mvc.AddControllersWithViews
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}

//creating the first controller