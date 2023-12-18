using OtogarSeferTakip.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OtogarSeferTakip.Models
{
    public class EditBusModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(20)]
        [MaxLength(20)]
        [MinLength(5)]
        public string BusPlate { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(10)]
        [MaxLength(10)]
        [MinLength(1)]
        public string BusType { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(20)]
        [MaxLength(20)]
        [MinLength(1)]
        public string BusBrand { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(20)]
        [MaxLength(20)]
        [MinLength(1)]
        public string BusModelName { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(10)]
        [MaxLength(10)]
        [MinLength(1)]
        public string BusEngineNumber { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [ForeignKey("Tako")]
        public int TakoId { get; set; }

        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        public string TakoNumber { get; set; }
        public string? Done { get; set; }
    }
}
