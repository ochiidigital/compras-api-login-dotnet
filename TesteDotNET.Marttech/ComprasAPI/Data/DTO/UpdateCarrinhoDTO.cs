using ComprasAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Data.DTO
{
    public class UpdateCarrinhoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int ClienteId { get; set; }

        [JsonIgnore]
        public virtual List<Item> Itens { get; set; }

        public double Total { get; set; }
    }
}
