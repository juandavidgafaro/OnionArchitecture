using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyect.DTOs;
using Proyect.Presenters;
using Proyect.UseCasesPorts;

namespace Proyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteProductController
    {
        readonly IDeleteProductInputPort _inputPort;
        readonly IDeleteProductOutputPort _outputPort;

        public DeleteProductController(
            IDeleteProductInputPort inputPort,
            IDeleteProductOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<bool> DeleteProduct(DeleteProductByIdDTO product)
        {
            await _inputPort.Handle(product);

            var result = ((IPresenter<Boolean>)_outputPort).Content;

            return result;
        }
    }
}
