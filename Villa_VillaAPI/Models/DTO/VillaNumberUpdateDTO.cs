﻿using System.ComponentModel.DataAnnotations;

namespace Villa_VillaAPI.Models.DTO
{
    public class VillaNumberUpdateDTO
    {

        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }

    }
}
