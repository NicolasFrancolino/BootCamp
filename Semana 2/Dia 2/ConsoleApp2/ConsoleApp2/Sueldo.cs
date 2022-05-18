using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Sueldo : BaseSueldo
    {
        public Sueldo(){}
        public override double CalcSueldo()
        {
            DatoEmpleado.nuevoSueldo = DatoEmpleado.Sueldo * DatoEmpleado.Aumento;
            return DatoEmpleado.nuevoSueldo;    
        }
              
    }
}
