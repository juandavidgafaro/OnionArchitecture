using Proyect.DTOs;
using Proyect.Entities.Interfaces;
using Proyect.UseCasesPorts;

namespace Proyect.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository _repository;
        readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsInteractor(
            IProductRepository repository,
            IGetAllProductsOutputPort outputPort) =>
            (_repository, _outputPort) = (repository, outputPort);

        public Task Handle()
        {
            var products = _repository.GetAll().Select(p =>
                new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name
                }
            );

            _outputPort.Handle(products);

            return Task.CompletedTask;
        }
    }
}
