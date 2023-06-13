using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AppleStoreTupinikim.Models
{
    public class Cliente
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "O campo Login é obrigatório.")]
        public string Login { get; set; }
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string Senha { get; set; }

    }
}
