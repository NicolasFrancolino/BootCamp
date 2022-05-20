using System.ComponentModel.DataAnnotations;

namespace WebApp.Code.Models
{
    public class Pelicula
    {
        [Key]
        public int IdPelicula { get; set; }
        public string? Titulo { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal Precio { get; set; }
       
    }
}
