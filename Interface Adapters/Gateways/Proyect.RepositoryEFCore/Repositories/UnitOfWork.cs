using Proyect.Entities.Interfaces;
using Proyect.RepositoryEFCore.DataContext;

namespace Proyect.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ProyectContext _proyectContext;

        public UnitOfWork(ProyectContext proyectContext) =>
            _proyectContext = proyectContext;

        public Task<int> SaveChanges()
        {
            return _proyectContext.SaveChangesAsync();
        }
    }
}
