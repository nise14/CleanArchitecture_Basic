using Entities.Interfaces;
using Entities.POCOs;
using RepositoryEFCore.DataContext;

namespace RepositoryEFCore.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly Context _context;

    public ProductRepository(Context context)
    {
        _context = context;
    }

    public void CreateProduct(Product product)
    {
        _context.Add(product);
    }

    public IEnumerable<Product> GetAll()
    {
       return _context.Products;
    }
}