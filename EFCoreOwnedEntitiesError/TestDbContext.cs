using EFCoreOwnedEntitiesError.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreOwnedEntitiesError;

internal class TestDbContext : DbContext
{
    public DbSet<Foo> Foos { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test")
            .LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestDbContext).Assembly);
    }
}