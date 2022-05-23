using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Class
{
    public partial class Persona 
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }

        public Persona(string nombre , int dni)
        {
            Nombre = nombre;
            Dni = dni;
        }
        public Persona() { }

    }
}
