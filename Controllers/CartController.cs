using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_project.Data;
using web_project.Models;

namespace web_project.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext _context;
        private readonly UserManager<User> _userManager;
        public CartController(DataContext context, UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var cartItems = await _context.Cart.Where(c => c.CustomerID == userId)
                .Include(c => c.Product).ToListAsync();
            return View(cartItems);
        }

        public async Task<IActionResult> AddToCart(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            var user = await _userManager.GetUserAsync(User);

            var cartItem = await _context.Cart.Where(c => c.CustomerID == user.Id)
                .FirstOrDefaultAsync(p => p.ProductID == product.ID);

            if (cartItem == null)
            {
                var cart = new Cart
                {
                    Product = product,
                    Customer = user,
                    Price = product.Price,
                    Quantity = 1
                };

                _context.Cart.Add(cart);
            }
            else
            {
                cartItem.Quantity += 1;

                _context.Cart.Update(cartItem);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Product", "Home", new {id = product.ID});
        }

        public IActionResult Billing()
        {
            return View();
        }
    }
}