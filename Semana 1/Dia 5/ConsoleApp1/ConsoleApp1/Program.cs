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
            Estudiante estudiante = new Estudiante();
            Profesor profesor = new Profesor();

            Console.Write("CUAL ES LA EDAD DEL ESTUDIANDTE:");
            int edad = Convert.ToInt32(Console.ReadLine());
            estudiante.setEdad(edad);
            Console.WriteLine($"EL ESTUDIANTE ESTA{estudiante.Estudiar()} Y SU EDAD ES {estudiante.verEdad()}");
            
            Console.WriteLine($"EL PROFESOR ESTA {profesor.Explicar()}");
            Console.ReadKey();
        }
    }
}
