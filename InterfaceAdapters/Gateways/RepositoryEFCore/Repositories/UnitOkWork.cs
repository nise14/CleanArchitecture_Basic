using Entities.Interfaces;
using RepositoryEFCore.DataContext;

namespace RepositoryEFCore.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly Context _context;

    public UnitOfWork(Context context) =>
    _context = context;


    public Task<int> SaveChanges()
    {
        return _context.SaveChangesAsync();
    }
}