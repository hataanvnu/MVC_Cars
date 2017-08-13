﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCarContactList.Models.ViewModels
{
    public class CarsCreateVM
    {
        [Display(Name ="Make")]
        [Required(ErrorMessage = "You must provide a Brand.")]
        public string Brand { get; set; }

        [Range(3, 5, ErrorMessage = "The number of cars must be between 3 and 5.")]
        [Required]
        public int Doors { get; set; }

        [Range(0, 300, ErrorMessage = "Top speed cannot be more than 300")]
        [Required]
        [Display(Name = "Top Speed")]
        public int TopSpeed { get; set; }

    }
}
