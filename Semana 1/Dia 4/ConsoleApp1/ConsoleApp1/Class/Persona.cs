using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Persona
    {
        private readonly string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return nombre.ToString();
        }

    }

}
