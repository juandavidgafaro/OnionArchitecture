using Proyect.Entities.POCOs;

namespace Proyect.Entities.Interfaces
{
    public interface IProductRepository
    {
        void Create(Product product);
        IEnumerable<Product> GetAll();
        bool Delete(int id);
    }
}
