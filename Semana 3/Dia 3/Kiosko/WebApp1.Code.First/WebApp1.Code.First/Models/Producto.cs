using System.ComponentModel.DataAnnotations;

namespace WebApp1.Code.First.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        public string? Categoria  { get; set; }
        public DateTime FechaBaja { get; set; }
        public ICollection<Caracteristica>? Caracteristicas { get; set; }
    }
}
