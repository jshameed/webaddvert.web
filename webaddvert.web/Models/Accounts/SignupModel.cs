using System.ComponentModel.DataAnnotations;

namespace webaddvert.web.Models.Accounts
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage ="Minimum length 6")]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Minimum length 6")]
        [Compare("Password",ErrorMessage ="Password and its confirmation dont match")]
        public string ConfirmPassword { get; set; }

    }
}
