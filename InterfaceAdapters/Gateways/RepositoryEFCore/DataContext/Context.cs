using Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace RepositoryEFCore.DataContext;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}