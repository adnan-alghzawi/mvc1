using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
    }
}
