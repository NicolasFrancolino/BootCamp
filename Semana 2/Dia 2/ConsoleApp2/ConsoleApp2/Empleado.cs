using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Empleado : Categoria
    {
        
        public Empleado( string nombre, double sueldo, Categoria Tcategoria)
        {
            
            Nombre = nombre;
            Sueldo = sueldo;
            nuevoSueldo = 0;
        }

        
        public string Nombre { get; set; }
        public double Sueldo { get; set; }
        public double nuevoSueldo { get; set; }
        
    }
}
