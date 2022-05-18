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
            Persona objPersona = new Persona();
            string dato;
            Console.Write("INGRESE UNA PERSONA:");
            dato = Console.ReadLine();
            objPersona.setPersona(new Persona(dato));
            Console.WriteLine($"LA PERSONA ES: {objPersona.ToString()}");
            Console.ReadKey();
        
                  
        }
        
    }
}
