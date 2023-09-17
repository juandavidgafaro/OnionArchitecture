using Proyect.DTOs;
using Proyect.Entities.Interfaces;
using Proyect.UseCasesPorts;

namespace Proyect.UseCases.DeleteProduct
{
    public class DeleteProductInteractor : IDeleteProductInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IUnitOfWork _unitOfWork;
        readonly IDeleteProductOutputPort _deleteProductOutputPort;

        public DeleteProductInteractor(IProductRepository productRepository,
                                        IUnitOfWork unitOfWork,
                                        IDeleteProductOutputPort deleteProductOutputPort) =>
                                        (_productRepository, _unitOfWork, _deleteProductOutputPort) =
                                        (productRepository, unitOfWork, deleteProductOutputPort);

        public async Task Handle(DeleteProductByIdDTO productId)
        {
            DeleteProductByIdDTO _product = new DeleteProductByIdDTO
            {
                Id = productId.Id,
            };

            var result = _productRepository.Delete(_product.Id);
            await _unitOfWork.SaveChanges();
            await _deleteProductOutputPort.Handle(result);
        }
    }
}
