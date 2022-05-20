using System.ComponentModel.DataAnnotations;

namespace WebApp1.Code.First.Models
{
    public class Caracteristica
    {
        [Key]
        public int Id { get; set; }
        public decimal Precio { get; set; }
        public decimal Ancho  { get; set; }
        public decimal Largo { get; set; }
        public decimal Peso { get; set; }
        public Producto? Producto { get; set; }

    }

}
