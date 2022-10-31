using DTOs;
using Microsoft.AspNetCore.Mvc;
using Presenters;
using UseCasesPorts;

namespace Controllers;

[Route("api/[controller]")]
[ApiController]
public class GetAllProductsController
{
    private readonly IGetAllProductsInputPort _inputPort;
    private readonly IGetAllProductsOutputPort _outputPort;

    public GetAllProductsController(IGetAllProductsInputPort inputPort, IGetAllProductsOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    [HttpGet]
    public async Task<IEnumerable<ProductDTO>> GetAllProducts()
    {
        await _inputPort.Handle();
        return ((IPresenter<IEnumerable<ProductDTO>>)_outputPort).Content;
    }
}