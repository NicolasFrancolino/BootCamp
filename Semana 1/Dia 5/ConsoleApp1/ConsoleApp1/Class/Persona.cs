using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Persona
    {
       /* public int Edad { get; set; }

        public Persona(int edad)
        {
            Edad = edad;
        }*/
        public  void setEdad(int edad)
        {
            Console.WriteLine("QUE EDAD TIENE:");
            edad = Convert.ToInt32(Console.ReadLine());
        }
        public void Saludar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SALUDANDO");
        }
    }
}
