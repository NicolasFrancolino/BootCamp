using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Persona
    {
        private string nombre;

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
        public Persona() { }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString() => Nombre;

        List<Persona> list = new List<Persona>();
        public void setPersona(Persona persona)
        {
            if (nombre != null)   list.Add();    
        }
    } 
}
