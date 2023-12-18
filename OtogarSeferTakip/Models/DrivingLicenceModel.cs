using System.ComponentModel.DataAnnotations;

namespace OtogarSeferTakip.Models
{
    public class DrivingLicenceModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(20)]
        [MaxLength(20)]
        [MinLength(5)]
        public string LicenceNo { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(100)]
        [MaxLength(100)]
        [MinLength(1)]
        public string Name { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(100)]
        [MaxLength(100)]
        [MinLength(1)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "*Boş bırakılamaz.")]
        [StringLength(1)]
        [MaxLength(1)]
        [MinLength(1)]
        public string Gender { get; set; }
        public string? Done { get; set; }
    }
}
