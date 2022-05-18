using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Persona
    {
        public int edad { get; set; }
        public Persona(int edad)
        {
           this.edad = edad;
        }
        public Persona() {}
        public void setEdad(int dato)
        {
          edad = dato;
        }
        public void Saludar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SALUDANDO");
        }
    }
}
