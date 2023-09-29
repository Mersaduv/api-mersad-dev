namespace mersad_dev.Data;

using mersad_dev.Configurations;
using mersad_dev.Entities.Courses;

using Microsoft.EntityFrameworkCore;


public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Course>? Courses { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CourseEntityConfiguration());
        base.OnModelCreating(modelBuilder);
    }

}
