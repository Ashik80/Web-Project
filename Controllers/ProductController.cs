using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_project.Data;
using web_project.Models;
using web_project.Models.ViewModels;

namespace web_project.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IWebHostEnvironment _environment;
        private readonly DataContext _context;
        public ProductController(ILogger<ProductController> logger, IWebHostEnvironment environment, DataContext context)
        {
            _context = context;
            _environment = environment;
            _logger = logger;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var filename = UploadedFile(model.Image);

                    var product = new Product
                    {
                        Name = model.Name,
                        Category = model.Category,
                        Quantity = model.Quantity,
                        Price = model.Price,
                        Image = filename
                    };

                    _context.Products.Add(product);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Admin");
                }
                catch (Exception ex)
                {
                    _logger.LogError("Problem adding product", ex);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            var model = new ProductViewModel
            {
                ID = product.ID,
                Name = product.Name,
                Category = product.Category,
                Quantity = product.Quantity,
                Price = product.Price
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductViewModel model)
        {
            if (id != model.ID)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            DeleteFile(product.Image);

            if (ModelState.IsValid)
            {
                string filename = UploadedFile(model.Image);

                product.Name = model.Name;
                product.Category = model.Category;
                product.Quantity = model.Quantity;
                product.Price = model.Price;
                product.Image = filename;

                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Admin");
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);

            try
            {
                DeleteFile(product.Image);
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                _logger.LogError("Problem deleting product", ex);
            }

            return View(product);

        }

        private string UploadedFile(IFormFile photo)
        {
            string file = "Pabo";
            if (photo != null)
            {
                string folderPath = Path.Combine(_environment.WebRootPath, "img");
                file = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string filePath = Path.Combine(folderPath, file);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    photo.CopyTo(filestream);
                }
            }
            return file;
        }

        private void DeleteFile(string photo)
        {
            string path = Path.Combine(_environment.WebRootPath, "img");
            string filepath = Path.Combine(path, photo);
            System.IO.File.Delete(filepath);
        }
    }
}