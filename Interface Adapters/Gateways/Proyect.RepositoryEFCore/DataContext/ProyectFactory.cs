using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Proyect.RepositoryEFCore.DataContext
{
    public class ProyectFactory : IDesignTimeDbContextFactory<ProyectContext>
    {
        public ProyectContext CreateDbContext(string[] args)
        {
            var optionBuilder =
                new DbContextOptionsBuilder<ProyectContext>();

            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; database=Store");
            return new ProyectContext(optionBuilder.Options);
        }
    }
}
