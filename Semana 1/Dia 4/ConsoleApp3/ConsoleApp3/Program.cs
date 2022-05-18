using ConsoleApp3.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Cuenta cuenta = new Cuenta(persona, 30.000);
           
            Console.ReadKey();


        }
     
    }
}
 

