using DTOs;
using Microsoft.AspNetCore.Mvc;
using Presenters;
using UseCasesPorts;

namespace Controllers;

[Route("api/[controller]")]
[ApiController]
public class CreateProductController
{
    private readonly ICreateProductInputPort _inputPort;
    private readonly ICreateProductOutputPort _outputPort;

    public CreateProductController(ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    [HttpPost]
    public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
    {
        await _inputPort.Handle(product);
        return ((IPresenter<ProductDTO>)_outputPort).Content;
    }
}
