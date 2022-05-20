using System.ComponentModel.DataAnnotations;

namespace WebApp.Code.Models
{
    public class Vehiculo
    {
        [Key]
        public int IdVehiculo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Importe { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
