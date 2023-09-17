using Proyect.DTOs;

namespace Proyect.UseCasesPorts
{
    public interface IDeleteProductInputPort
    {
        Task Handle(DeleteProductByIdDTO productId);
    }
}
