namespace mersad_dev.Data;

using Entities;
using Microsoft.EntityFrameworkCore;


public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Course>? Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Course>().HasData(
            new Course()
            {
                Id = Guid.NewGuid(),
                Title = "evlore,pw",
                Tuition = 100,
                Instructor = "mrsd",
                CategoryId = 1,
                Category = "course",
                IsOnline = true,
                Created = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
            },
            new Course()
            {
                Id = Guid.NewGuid(),
                Title = "evlore,pw",
                Tuition = 200,
                Instructor = "mrsd 2",
                CategoryId = 1,
                Category = "course",
                IsOnline = true,
                Created = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
            });

    }

}
