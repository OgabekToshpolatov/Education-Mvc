using Microsoft.EntityFrameworkCore;
using mvc.Entities;

namespace mvc.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Student>? Students { get ; set ;}
    public DbSet<Group>? Groups { get ; set ;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<Student>()
            .HasOne(p => p.Group)
            .WithMany(b => b.Students)
            .HasForeignKey(p => p.GroupId);
    }
}