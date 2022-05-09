using ConsoleApp2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona this_persona = new Persona("LUCAS", 32, 35336675);
            this_persona.Show();
            Console.WriteLine(this_persona.isAdult());
            Console.ReadKey();
        }
        
        
    }
}

