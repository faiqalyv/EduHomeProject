using System;
using System.ComponentModel.DataAnnotations;

namespace EDUHome.Core.Entities;

public class Choose
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Title { get; set; } = null!;

    [Required, MaxLength(255)]
    public string Description { get; set; } = null!;

    [Required, MaxLength(255)]
    public string Description2 { get; set; } = null!;

}

