﻿using EDUHome.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EDUHome.Core.Entities;

public class Course : IEntity
{
    public int Id { get ; set ; }

    [Required,MaxLength(30)]
    public string? Title { get; set ; }

    [Required, MaxLength(120)]
    public string? Description { get; set ; }

    [Required, MaxLength(255)]
    public string? ImagePath { get; set ; }

    public int CourseCatagoryId { get; set; }
    public CourseCatagory CourseCatagory { get; set; }

}
