using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Class
{
    public abstract class Persona : IPersona
    {
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

        public void Action(string type_Action)
        {
            Console.WriteLine(type_Action);
        }  
    }
}
