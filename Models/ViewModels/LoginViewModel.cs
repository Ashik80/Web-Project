using System.ComponentModel.DataAnnotations;

namespace web_project.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string InRole { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}