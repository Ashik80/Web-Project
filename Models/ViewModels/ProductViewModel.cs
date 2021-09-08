using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace web_project.Models.ViewModels
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(NullDisplayText = "No category")]
        public Category? Category { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Upload an image first")]
        public IFormFile Image { get; set; }
    }
}