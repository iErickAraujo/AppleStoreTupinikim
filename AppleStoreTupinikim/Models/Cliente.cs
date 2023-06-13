using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AppleStoreTupinikim.Models
{
    public class Cliente
    {
        //[Display(Name = "IdCliente")]
        //public string IdCliente { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DataType(DataType.Text, ErrorMessage = "O Campo está Vazio")]
        //[Display(Name = "Nome")]
        //[Required(ErrorMessage = "Preenchimento obrigatorio")]
        //[DataType(DataType.Text, ErrorMessage = "O Campo está Vazio")]
        public string Nome { get; set; }
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DataType(DataType.Text, ErrorMessage = "O Campo está Vazio")]
        public string Senha { get; set; }

    }
}
