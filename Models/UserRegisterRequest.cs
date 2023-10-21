using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class UserRegisterRequest
    {
        [Required,EmailAddress]
        [Display(Name="User Email", Prompt = "Enter Email ...")]
        public string Email { get; set; }


        [Required,MinLength(6,ErrorMessage ="Atleast 6 charcter required")]
        [Display(Name = "Password", Prompt = "Password")]

        public string Password { get; set; }

      
        [Required, MinLength(6, ErrorMessage = "Atleas 6 character required")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Display(Name = "Confirm Password", Prompt = "Confirm Password ")]
        public string ConfirmPassword { get; set; }

    }
}
