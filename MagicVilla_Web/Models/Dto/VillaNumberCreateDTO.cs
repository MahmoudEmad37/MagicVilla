﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int villaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string specialDetails { get; set; }
    }
}