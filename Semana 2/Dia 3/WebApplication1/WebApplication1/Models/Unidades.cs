using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Unidades
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Year { get; set; }
        public double Kilometros { get; set; }
        public double Precio { get; set; }
    }
}