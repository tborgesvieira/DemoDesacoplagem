using System.ComponentModel.DataAnnotations;

namespace DD.DemoDesacoplagem.Infra.CrossCutting.Identity.ModelModel
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nome da Role")]
        public string Name { get; set; }
    }
}