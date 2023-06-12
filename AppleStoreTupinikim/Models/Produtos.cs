using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AppleStoreTupinikim.Models
{
    public class Produtos
    {
        [Display(Name = "IdProduto")]
        public string IdProduto { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DataType(DataType.Text, ErrorMessage = "O Campo está Vazio")]
        public string Nome { get; set; }
        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DataType(DataType.Text, ErrorMessage = "O Campo está Vazio")]
        public string Valor { get; set; }
        [Display(Name = "Estoque")]
        [Required(ErrorMessage = "Preenchimento obrigatorio")]
        [DataType(DataType.Text, ErrorMessage = "O Campo está Vazio")]
        public string Estoque { get; set; }
    }
}
