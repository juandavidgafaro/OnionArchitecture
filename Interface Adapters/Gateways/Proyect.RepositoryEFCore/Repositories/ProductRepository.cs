using Proyect.Entities.Interfaces;
using Proyect.Entities.POCOs;
using Proyect.RepositoryEFCore.DataContext;

namespace Proyect.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly ProyectContext _proyectContext;

        public ProductRepository(ProyectContext proyectContext) =>
            _proyectContext = proyectContext;

        public void Create(Product product)
        {
            _proyectContext.Add(product);
        }

        public bool Delete(int id)
        {
            var result = _proyectContext.RemoveById<Product>(id);

            return result;
        }

        public IEnumerable<Product> GetAll()
        {
            return _proyectContext.Products;
        }
    }
}
