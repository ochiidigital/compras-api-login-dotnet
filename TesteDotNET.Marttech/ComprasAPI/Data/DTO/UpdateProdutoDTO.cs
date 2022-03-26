using System.ComponentModel.DataAnnotations;

namespace ComprasAPI.Data.DTO
{
    public class UpdateProdutoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Descricao { get; set; }

        public string FotoUrl { get; set; }

        public double Preco { get; set; }
    }
}
