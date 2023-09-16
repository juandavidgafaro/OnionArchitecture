using Microsoft.EntityFrameworkCore;
using Proyect.Entities.POCOs;

namespace Proyect.RepositoryEFCore.DataContext
{
    public class ProyectContext : DbContext
    {
        public ProyectContext(DbContextOptions<ProyectContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
