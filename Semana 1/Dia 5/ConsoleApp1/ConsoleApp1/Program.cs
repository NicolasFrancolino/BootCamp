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
            Persona persona = new Persona();
            Estudiante estudiante = new Estudiante();
            Profesor profesor = new Profesor();

            persona.Saludar();
            estudiante.Estudiar();
            profesor.Explicar();
            Console.ReadKey();
        }
    }
}
