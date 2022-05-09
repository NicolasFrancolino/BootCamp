using ConsoleApp1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] Array = new Persona[3];

            for ( int item = 0; item < Array.Length; item++)
            {
                Console.Write("INGRESE NOMBRE: ");
                Array[item].ToString();
            }            
            Console.ReadKey();
        }
        
    }
}
