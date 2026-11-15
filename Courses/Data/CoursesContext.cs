using Microsoft.EntityFrameworkCore;
using Courses.Models;

namespace Courses.Data;

public class CoursesContext : DbContext
{
    public CoursesContext(DbContextOptions<CoursesContext> options)
        : base(options) { }

    public DbSet<Course> Courses => Set<Course>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        // Перетворення decimal у double для коректного сортування та обчислень у SQLite
        b.Entity<Course>().Property(x => x.Price).HasConversion<double>();
    }
}