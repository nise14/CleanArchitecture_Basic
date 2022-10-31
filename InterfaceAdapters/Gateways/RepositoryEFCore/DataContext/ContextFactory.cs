using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RepositoryEFCore.DataContext;

public class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<Context> optionBuilder = new DbContextOptionsBuilder<Context>();
        optionBuilder.UseSqlServer(
            "Server=.;database=CleanArchitecture;Integrated Security=true;"
        );

        return new Context(optionBuilder.Options);
    }
}