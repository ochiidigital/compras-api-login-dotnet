using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Models
{
    public class Item
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [JsonIgnore]
        public virtual Produto Produto { get; set; }

        [Required]
        public int ProdutoId { get; set; }

        public double SubTotal { get; set; }

        [JsonIgnore]
        public virtual Carrinho Carrinho { get; set; }

        [Required]
        public int CarrinhoId { get; set; }
    }
}
