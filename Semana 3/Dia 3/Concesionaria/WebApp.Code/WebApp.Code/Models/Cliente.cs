using System.ComponentModel.DataAnnotations;

namespace WebApp.Code.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }
        public string? Direccion { get; set; }
    }
}
