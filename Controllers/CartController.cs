using Microsoft.AspNetCore.Mvc;

namespace web_project.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Billing()
        {
            return View();
        }
    }
}