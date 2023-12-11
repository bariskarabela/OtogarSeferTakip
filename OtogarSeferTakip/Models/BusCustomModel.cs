using OtogarSeferTakip.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OtogarSeferTakip.Models
{
    public class BusCustomModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MaxLength(20)]
        [MinLength(5)]
        public string BusPlate { get; set; }
        [Required]
        [StringLength(10)]
        [MaxLength(10)]
        [MinLength(1)]
        public string BusType { get; set; }
        [Required]
        [StringLength(20)]
        [MaxLength(20)]
        [MinLength(1)]
        public string BusBrand { get; set; }
        [Required]
        [StringLength(20)]
        [MaxLength(20)]
        [MinLength(1)]
        public string BusModel { get; set; }
        [Required]
        [StringLength(10)]
        [MaxLength(10)]
        [MinLength(1)]
        public string BusEngineNumber { get; set; }
        [Required]
        [ForeignKey("Tako")]
        public int TakoId { get; set; }
        public Tako Tako { get; set; }
    
        [Required]
        public string TakoNumber { get; set; }
        public string? Done { get; set; }
    }
}
