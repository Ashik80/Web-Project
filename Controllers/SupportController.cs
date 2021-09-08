using Microsoft.AspNetCore.Mvc;

namespace web_project.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}