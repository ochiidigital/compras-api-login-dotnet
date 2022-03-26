using System.ComponentModel.DataAnnotations;

namespace ComprasAPI.Models
{
    public class Email
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string EnderecoDeEmail { get; set; }

        public int ClienteId { get; set; }
    }
}
