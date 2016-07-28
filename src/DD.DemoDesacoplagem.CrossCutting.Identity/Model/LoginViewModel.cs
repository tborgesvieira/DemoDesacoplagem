using System.ComponentModel.DataAnnotations;

namespace DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Model
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Relembrar?")]
        public bool RememberMe { get; set; }
    }
}