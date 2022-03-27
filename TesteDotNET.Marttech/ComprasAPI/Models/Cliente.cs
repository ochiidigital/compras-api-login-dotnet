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

        [Required]
        public virtual List<Email> Emails { get; set; }

        [Required]
        public virtual List<Telefone> Telefones { get; set; }

        [Required]
        public virtual Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }

        public virtual Carrinho Carrinho { get; set; }

        public int CarrinhoId { get; set; }

        public int UsuarioId { get; set; }
    }
}
