using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Estudiante : Persona
    {

        public string Estudiar() => "ESTUDIANDO";
       
        public int verEdad() => edad;
    }
}
