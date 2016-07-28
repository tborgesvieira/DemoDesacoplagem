using System.ComponentModel.DataAnnotations;

namespace DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Model
{
    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "C�digo")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Relembrar nesse navegador?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }
}