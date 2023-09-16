using Microsoft.AspNetCore.Mvc;
using Proyect.DTOs;
using Proyect.Presenters;
using Proyect.UseCasesPorts;

namespace Proyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllProductsInputPort _inputPort;
        readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsController(
            IGetAllProductsInputPort inputPort,
            IGetAllProductsOutputPort outputPort) =>
            (_inputPort, _outputPort) =
            (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDTO>>)_outputPort).Content;
        }
    }
}
