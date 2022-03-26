using ComprasAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Data.DTO
{
    public class CreateClienteDTO
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [JsonIgnore]
        public virtual List<Email> Emails { get; set; }

        [JsonIgnore]
        public virtual List<Telefone> Telefones { get; set; }

        [JsonIgnore]
        public virtual Endereco Endereco { get; set; }

        [Required]
        public int EnderecoId { get; set; }

        [JsonIgnore]
        public virtual Carrinho Carrinho { get; set; }
    }
}
