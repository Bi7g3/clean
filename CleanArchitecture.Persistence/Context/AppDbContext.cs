using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Context;

public sealed class AppDbContext:DbContext
{
    AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {

    }
}
