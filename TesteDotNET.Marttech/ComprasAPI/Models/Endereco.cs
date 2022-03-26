using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public int Numero { get; set; }

        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public int CEP { get; set; }

        [Required]
        public string UF { get; set; }

        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }
    }
}
