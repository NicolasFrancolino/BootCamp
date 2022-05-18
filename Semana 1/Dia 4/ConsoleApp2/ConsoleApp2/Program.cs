using ConsoleApp2.Class;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("LUCAS", 32, 35336675);
            persona.getData();
            Console.WriteLine($"\nEs adulto:{persona.isAdult()}");
            Console.ReadKey();
        }
        
        
    }
}

