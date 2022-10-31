using DTOs;
using Entities.Interfaces;
using Entities.POCOs;
using UseCasesPorts;

namespace UseCases.CreateProduct;

public class CreateProductInteractor : ICreateProductInputPort
{
    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateProductOutputPort _outputPort;

    public CreateProductInteractor(IProductRepository repository, IUnitOfWork unitOfWork, ICreateProductOutputPort outputPort)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
    }

    public async Task Handle(CreateProductDTO product)
    {
        Product newProduct = new Product
        {
            Name = product.ProductName
        };

        _repository.CreateProduct(newProduct);
        await _unitOfWork.SaveChanges();
        await _outputPort.Handle(new ProductDTO
        {
            Id = newProduct.Id,
            Name = newProduct.Name
        });
    }
}