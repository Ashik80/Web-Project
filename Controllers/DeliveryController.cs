using Microsoft.AspNetCore.Mvc;

namespace web_project.Controllers
{
    public class DeliveryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}