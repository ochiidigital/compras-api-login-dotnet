using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComprasAPI.Models
{
    public class Telefone
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Numero { get; set; }

        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }

        public int ClienteId { get; set; }
    }
}
