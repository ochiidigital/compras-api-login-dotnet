using ComprasAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComprasAPI.Data.DTO
{
    public class CreateCarrinhoDTO
    {
        [Required]
        public int ClienteId { get; set; }

        [Required]
        public virtual List<Item> Itens { get; set; }

        [Required]
        public double Total { get; set; }
    }
}

