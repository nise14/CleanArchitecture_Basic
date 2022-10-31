using DTOs;
using UseCasesPorts;

namespace Presenters;

public class CreateProductPresenters : ICreateProductOutputPort, IPresenter<ProductDTO>
{
    public ProductDTO Content { get; private set; }

    public Task Handle(ProductDTO product)
    {
        Content = product;

        return Task.CompletedTask;
    }
}