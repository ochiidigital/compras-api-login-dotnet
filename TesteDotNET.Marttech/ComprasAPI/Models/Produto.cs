using System.ComponentModel.DataAnnotations;

namespace ComprasAPI.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string FotoUrl { get; set; }

        [Required]
        public double Preco { get; set; }
    }
}
