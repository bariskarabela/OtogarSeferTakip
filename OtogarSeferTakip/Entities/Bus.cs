﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtogarSeferTakip.Entities
{
    public class Bus
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
        public Tako Tako { get; set; }
        [Required]
        public string TakoNumber { get; set; }
       
    }
}
