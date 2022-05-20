using Microsoft.EntityFrameworkCore;
using WebApp.Code.Models;

namespace WebApp.Code.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }
        
        public  DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }

    }
}
