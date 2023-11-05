using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
