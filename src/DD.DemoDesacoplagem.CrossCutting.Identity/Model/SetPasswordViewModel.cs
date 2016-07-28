using System.ComponentModel.DataAnnotations;

namespace DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Model
{
    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "A {0} senha deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("NewPassword", ErrorMessage = "A senha não confere.")]
        public string ConfirmPassword { get; set; }
    }
}