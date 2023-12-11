using System.ComponentModel.DataAnnotations;

namespace OtogarSeferTakip.Models
{
    public class TakoModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(30)]
        [MaxLength(30)]
        public string TakoName { get; set; }
        public string? Done { get; set; }
    }
}
