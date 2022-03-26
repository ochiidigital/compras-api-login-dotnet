using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [JsonIgnore]
        public virtual List<Email> Emails { get; set; }

        [JsonIgnore]
        public virtual List<Telefone> Telefones { get; set; }

        public virtual Endereco Endereco { get; set; }

        [Required]
        public int EnderecoId { get; set; }

        [JsonIgnore]
        public virtual Carrinho Carrinho { get; set; }
    }
}
