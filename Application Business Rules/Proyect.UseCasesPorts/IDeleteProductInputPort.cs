using Proyect.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.UseCasesPorts
{
    public interface IDeleteProductInputPort
    {
        Task Handle(DeleteProductByIdDTO productId);
    }
}
