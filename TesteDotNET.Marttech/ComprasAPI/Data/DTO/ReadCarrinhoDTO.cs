using ComprasAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Data.DTO
{
    public class ReadCarrinhoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public virtual List<Item> Itens { get; set; }

        [Required]
        public double Total { get; set; }
    }
}
