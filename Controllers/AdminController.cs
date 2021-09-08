using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_project.Data;

namespace web_project.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _context;
        public AdminController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();

            return View(products);
        }

        public IActionResult Support()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }
    }
}