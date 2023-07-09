using System;
using System.ComponentModel.DataAnnotations;
using EDUHome.Core.Interfaces;

namespace EDUHome.Core.Entities;

public class Notice : IEntity
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Title { get; set; } = null!;

    [Required, MaxLength(255)]
    public string Description { get; set; } = null!;

    [Required]
    public Boolean isLeft { get; set; } = false;
}

