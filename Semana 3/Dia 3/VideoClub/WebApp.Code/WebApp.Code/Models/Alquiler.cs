using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Code.Models
{
    public class Alquiler
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get ; set; }
        public DateTime? FechaBaja { get; set; }

        // Clave externa que reprecenta al ID
        [ForeignKey("Pelicula")]
        public int IdPelicula { get; set; }

        //Objeto que reprecenta la clave externa
        [ForeignKey("IdPelicula")]
        public virtual Pelicula? Pelicula { get; set; }
    }
}
