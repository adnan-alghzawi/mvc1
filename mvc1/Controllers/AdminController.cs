using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
