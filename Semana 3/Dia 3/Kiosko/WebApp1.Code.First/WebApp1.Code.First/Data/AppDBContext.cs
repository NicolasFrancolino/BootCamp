using Microsoft.EntityFrameworkCore;

using WebApp1.Code.First.Models;

namespace WebApp1.Code.First.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options): base(options) { }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Caracteristica> Caracteristicas { get; set; }
    }
}
