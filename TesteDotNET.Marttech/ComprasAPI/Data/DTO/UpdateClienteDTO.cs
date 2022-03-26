using ComprasAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Data.DTO
{
    public class UpdateClienteDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        [JsonIgnore]
        public virtual List<Email> Emails { get; set; }

        [JsonIgnore]
        public virtual List<Telefone> Telefones { get; set; }

        [JsonIgnore]
        public virtual Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }

        [JsonIgnore]
        public virtual Carrinho Carrinho { get; set; }
    }
}
