﻿using System.ComponentModel.DataAnnotations;

namespace Pustok_project.ViewModels.SliderVM
{
    public class UpdateSliderVM
    {
        [Required]
        public string Title { get; set; }

        [Required, MinLength(3), MaxLength(64)]
        public string Text { get; set; }

        [Required, Range(0, float.MaxValue)]
        public float Price { get; set; }

        [Required, MinLength(3), MaxLength(256)]
        public string ImageUrl { get; set; }
        [Required]
        public bool IsLeft { get; set; }


    }
}
