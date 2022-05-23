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

            Persona persona = new Persona();
            Console.Write("CUAL ES EL NOMBRE DE LA PERSONA:");
            string name = Console.ReadLine();
            Console.Write("CUAL ES LA EDAD:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("CUAL ES EL NUMERO DE DOC:");
            int dni = int.Parse(Console.ReadLine());
            persona.setData(name, age, dni);
            Console.Clear();
            persona.getData();
            Console.ForegroundColor= ConsoleColor.Red;
            if (!persona.isAdult()==false)
                Console.WriteLine("ES ADULTO");
               else Console.WriteLine("ES MENOR");
            Console.ReadKey();

        }
        
        
    }
}

