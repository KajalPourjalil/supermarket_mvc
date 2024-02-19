using Microsoft.AspNetCore.Mvc;

namespace supermarket_mvc.Controllers
{
    public class CategoriessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}