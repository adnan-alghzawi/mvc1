using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Subscribe()
        {
            return View();
        }
    }
}
