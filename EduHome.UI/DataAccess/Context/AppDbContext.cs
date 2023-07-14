using System;
using EDUHome.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.DataAccess.Context;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<Course> courses { get; set; }
	public DbSet<CourseCatagory> courseCatagories { get; set; }
    public DbSet<Notice> notices { get; set; }
    public DbSet<Choose> chooses { get; set; }
    public DbSet<Testimonial> testimonials { get; set; }

}

