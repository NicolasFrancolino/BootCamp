using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Class
{
    public  class Cuenta 
    {
        public static object titular;

        public Persona Titular { get; set; }
        public decimal Cantidad { get; set; }

        public Cuenta(Persona titular, decimal cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }
       public static void Show()
        {
            Console.Write($"{titular}");|
        }
    }
}
