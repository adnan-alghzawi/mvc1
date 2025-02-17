using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Subscribe()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
