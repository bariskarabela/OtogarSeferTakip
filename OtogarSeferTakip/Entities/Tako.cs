using System.ComponentModel.DataAnnotations;

namespace OtogarSeferTakip.Entities
{
    public class Tako
    {
        [Key]
        public int TakoId { get; set; }
        [Required]
        [StringLength(30)]
        [MaxLength(30)]
        public string TakoName { get; set; }
    }
}
