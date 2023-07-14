using System;
using System.ComponentModel.DataAnnotations;

namespace EDUHome.Core.Entities
{
	public class Testimonial
	{
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;
        [Required, MaxLength(50)]
        public string Work { get; set; } = null!;


        [Required, MaxLength(255)]
        public string Description { get; set; } = null!;

        [Required, MaxLength(255)]
        public string ImagePath { get; set; } = null!;
    }
}

