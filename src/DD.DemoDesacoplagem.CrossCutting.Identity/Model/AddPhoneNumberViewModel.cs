using System.ComponentModel.DataAnnotations;

namespace DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Model
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Número de Telefone")]
        public string Number { get; set; }
    }
}