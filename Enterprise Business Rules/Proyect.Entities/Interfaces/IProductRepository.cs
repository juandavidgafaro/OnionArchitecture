using Microsoft.AspNetCore.Mvc;
using Proyect.Entities.POCOs;

namespace Proyect.Entities.Interfaces
{
    public interface IProductRepository
    {
        void Create(Product product);
        IEnumerable<Product> GetAll();
        IActionResult Delete (int id);
    }
}
