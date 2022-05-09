using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.Write("INGRESE CANTIDAD DE HORAS:"); 
            int hours = Convert.ToInt32(Console.ReadLine());
            double result; 
            if (hours > 5) 
            {
               hours--;
               result  = hours * 1.5;
               Console.WriteLine($"Tenes una hora gratis, total a pagar:{result}");
            }
            else
            {
                result = hours * 1.5;
                Console.WriteLine($"Total a pagar:{result}");
            }
            Console.ReadKey();
        }
    }
}
