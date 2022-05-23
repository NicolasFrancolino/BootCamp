using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Code.Models
{
    public class Venta
    {
        
        [Key]
        public int IdVenta { get; set; }
     //-------------------------------------
        [ForeignKey("Vehiculo")]
        public int IdVehiculo { get; set; }

        [ForeignKey("IdVehiculo")]
        public virtual Vehiculo Vehiculo { get ; set; } 
     //------------------------------------
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }
     //------------------------------------

        public decimal Importe { get; set; }
        public decimal Descuento { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;  
    }
}
