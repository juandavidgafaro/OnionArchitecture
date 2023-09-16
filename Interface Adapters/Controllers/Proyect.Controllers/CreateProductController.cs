using Microsoft.AspNetCore.Mvc;
using Proyect.DTOs;
using Proyect.Presenters;
using Proyect.UseCasesPorts;

namespace Proyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort _inputPort;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductController(
            ICreateProductInputPort inputPort,
            ICreateProductOutputPort outputPort) =>
            (_inputPort, _outputPort) =
            (inputPort, outputPort);

        [HttpPost]
        public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
        {
            await _inputPort.Handle(product);
            return ((IPresenter<ProductDTO>)_outputPort).Content;
        }
    }
}
