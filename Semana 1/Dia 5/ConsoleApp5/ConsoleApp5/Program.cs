using ConsoleApp5.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Console.Write("COMO SE LLAMA TU PERRO: ");
            string nombre = Console.ReadLine(); 
            perro.SetNombre(nombre);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{perro.GetNombre()} ESTA ");perro.comer();
            Console.ReadKey();
        }
    }
}
