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

        public Cliente Cliente { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [JsonIgnore]
        public List<Item> Itens { get; set; }

        public double Total { get; set; }
    }
}
