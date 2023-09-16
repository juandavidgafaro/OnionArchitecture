using Proyect.DTOs;
using Proyect.Entities.Interfaces;
using Proyect.Entities.POCOs;
using Proyect.UseCasesPorts;

namespace Proyect.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreateProductOutputPort _createProductOutputPort;

        public CreateProductInteractor(IProductRepository productRepository,
            IUnitOfWork unitOfWork,
            ICreateProductOutputPort createProductOutputPort) =>
            (_productRepository, _unitOfWork, _createProductOutputPort) =
            (productRepository, unitOfWork, createProductOutputPort);

        public async Task Handle(CreateProductDTO product)
        {
            Product NewProduct = new Product
            {
                Name = product.Name
            };
            _productRepository.Create(NewProduct);
            await _unitOfWork.SaveChanges();
            await _createProductOutputPort.Handle(
                new ProductDTO
                {
                    Id = NewProduct.Id,
                    Name = NewProduct.Name
                }
                );
        }
    }
}
