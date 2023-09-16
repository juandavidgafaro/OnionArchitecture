using Proyect.Entities.Interfaces;
using Proyect.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.UseCases.DeleteProduct
{
    public class DeleteProductInteractor : IDeleteProductInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IUnitOfWork _unitOfWork;
    }
}
