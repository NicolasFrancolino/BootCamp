using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConcesionariaApp.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string year { get; set; }
        public double Kilometros { get; set; }
        public double Precio { get; set; }
    }
}