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

        [Required]
        public virtual List<Email> Emails { get; set; }

        [Required]
        public virtual List<Telefone> Telefones { get; set; }

        [Required]
        public virtual Endereco Endereco { get; set; }

    }
}
