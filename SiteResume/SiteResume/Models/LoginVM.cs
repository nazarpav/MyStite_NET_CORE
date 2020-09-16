using System.ComponentModel.DataAnnotations;
namespace SiteResume.Models
{
    public class LoginVM
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter password")]
        public string Password { get; set; }
    }
}
