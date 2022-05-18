using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Class
{
    public abstract class Animal
    {
        private string nombre;

        public Animal(string nombre)
        {
            this.nombre = nombre;
        }

        public Animal()
        {

        }
        public string GetNombre() => nombre;
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public abstract void comer();
    }
}
