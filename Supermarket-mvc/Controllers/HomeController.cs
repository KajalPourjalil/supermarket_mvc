using Microsoft.AspNetCore.Mvc;

namespace supermarket_mvc.AddControllersWithViews
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "hi wold";
        }

        public string Error()
        {
            return "error";
        }
    }
}

//creating the first controller