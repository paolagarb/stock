using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Insira o nome do produto")]
        public string Nome { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage ="Insira o valor do produto")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Column(TypeName = "decimal(20,2)")]
        [Display(Name ="Preço")]
        public double Preco { get; set; }
        [Required(ErrorMessage = "Insira a quantidade")]
        public int Quantidade { get; set; }
        public Produto() { }
    }
}
