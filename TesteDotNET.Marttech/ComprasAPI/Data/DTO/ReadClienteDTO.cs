using ComprasAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Data.DTO
{
    public class ReadClienteDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        public virtual List<Email> Emails { get; set; }

        [JsonIgnore]
        public virtual List<Telefone> Telefones { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual Carrinho Carrinho { get; set; }
    }
}
