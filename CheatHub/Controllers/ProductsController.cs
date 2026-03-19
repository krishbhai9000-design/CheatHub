using Microsoft.AspNetCore.Mvc;

namespace CheatHub.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Free()
        {
            return View();
        }

        public IActionResult Paid()
        {
            return View();
        }

        public IActionResult Premium()
        {
            return View();
        }
    }
}
