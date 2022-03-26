using System.ComponentModel.DataAnnotations;

namespace ComprasAPI.Data.DTO
{
    public class CreateProdutoDTO
    {
        [Required]
        public string Descricao { get; set; }

        [Required]
        public string FotoUrl { get; set; }

        [Required]
        public double Preco { get; set; }
    }
}
