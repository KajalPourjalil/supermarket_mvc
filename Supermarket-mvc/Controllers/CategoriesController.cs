using Microsoft.AspNetCore.Mvc;

namespace supermarket_mvc.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Categories()
        {
            return View();
        }
    }
}