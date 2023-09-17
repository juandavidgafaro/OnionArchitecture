using Microsoft.EntityFrameworkCore;
using Proyect.Entities.POCOs;

namespace Proyect.RepositoryEFCore.DataContext
{
    public class ProyectContext : DbContext
    {
        public ProyectContext(DbContextOptions<ProyectContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public bool RemoveById<TEntity>(int id) where TEntity : class
        {
            var entity = this.Set<TEntity>().Find(id);
            if (entity != null)
            {
                this.Set<TEntity>().Remove(entity);
                return true;
            }
            return false;
        }
    }
}
