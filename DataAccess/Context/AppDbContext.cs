using EDUHome.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){ }

    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseCatagory> CourseCatagories { get; set; }
}
