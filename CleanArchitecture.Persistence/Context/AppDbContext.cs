using CleanArchitecture.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Context;

public sealed class AppDbContext:DbContext
{
    AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
   => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly); // Configuration dosyalarını tek tek yazmaya gerek yok.CarConfiguration..... gibi


    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entires = ChangeTracker.Entries<Entity>();
        foreach (var entry in entires)
        {
            if (entry.State == EntityState.Added)
                entry.Property(p => p.CreatedAt)
                    .CurrentValue = DateTimeOffset.Now;

            if (entry.State == EntityState.Modified)
                entry.Property(p => p.UpdatedAt)
                    .CurrentValue = DateTimeOffset.Now;
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
