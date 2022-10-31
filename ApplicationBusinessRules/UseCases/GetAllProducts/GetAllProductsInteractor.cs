using System.Linq;
using DTOs;
using Entities.Interfaces;
using UseCasesPorts;

namespace UseCases;

public class GetAllProductsInteractor : IGetAllProductsInputPort
{
    private readonly IProductRepository _repository;
    private readonly IGetAllProductsOutputPort _outputPort;

    public GetAllProductsInteractor(IProductRepository repository, IGetAllProductsOutputPort outputPort)
    {
        _repository = repository;
        _outputPort = outputPort;
    }

    public Task Handle()
    {
        var products = _repository.GetAll().Select(p =>

            new ProductDTO
            {
                Id = p.Id,
                Name = p.Name
            });

        _outputPort.Handle(products);

        return Task.CompletedTask;
    }
}