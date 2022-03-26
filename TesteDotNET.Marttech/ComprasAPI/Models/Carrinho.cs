using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Models
{
    public class Carrinho
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public virtual List<Item> Itens { get; set; }

        [Required]
        public double Total { get; set; }
    }
}
