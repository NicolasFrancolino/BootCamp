using Microsoft.EntityFrameworkCore;
using WebApp.Code.Models;

namespace WebApp.Code.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }
        public DbSet<Cliente> Clientes { get; set; }    
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Venta> Ventas { get; set; }    
    }
}
