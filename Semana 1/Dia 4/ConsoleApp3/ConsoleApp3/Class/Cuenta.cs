using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Class
{
   public  class Cuenta 
    {
        
        public Persona Titular { get; set; }
        public double Cantidad { get; set; }

        public Cuenta(Persona titular, double cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }
       public static void getData()
        {
            Console.WriteLine($"{}"); 
        }
    }
}
