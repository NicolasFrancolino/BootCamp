using System.ComponentModel.DataAnnotations;

namespace PairPro.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Marca { get; set; }
        [Required]
        public string? Modelo { get; set; }
        public string? Year{ get; set; }
        public double Kilometro  { get; set; }
        [Required]
        public double Precio  { get; set; }
    }
}
