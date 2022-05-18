using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class BaseSueldo
    { 
        public Empleado DatoEmpleado;

        public BaseSueldo(Empleado Type_empleado)
        {
            DatoEmpleado = Type_empleado;
        }
        public BaseSueldo()
        {
           
        }
        public abstract double CalcSueldo();
    }

}
