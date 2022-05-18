using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Categoria categoria = new Categoria(1, 1.5);
            Empleado empleado = new Empleado("Nico",90.000,categoria);
            Sueldo sueldo = new Sueldo();
            Console.WriteLine(sueldo.CalcSueldo());
            Console.ReadKey();

        }
    }
}
