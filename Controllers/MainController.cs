using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
