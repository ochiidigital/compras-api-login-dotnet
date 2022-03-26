using System.ComponentModel.DataAnnotations;

namespace ComprasAPI.Models
{
    public class Telefone
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int Numero { get; set; }

        public virtual Cliente Cliente { get; set; }

        public int ClienteId { get; set; }
    }
}
