﻿using System.ComponentModel.DataAnnotations;

namespace OtogarSeferTakip.Entities
{
    public class Tako
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="*Boş bırakılamaz.")]
        [StringLength(30)]
        [MaxLength(30)]
        public string TakoName { get; set; }
    }
}
