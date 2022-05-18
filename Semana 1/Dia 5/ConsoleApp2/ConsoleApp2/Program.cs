using ConsoleApp2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Estudiante objEstudiante = new Estudiante();
            objEstudiante.Action("Estudiando");
            Profesor objProfesor = new Profesor();
            objProfesor.Action("Explicando");
            Console.ReadKey();
        }
    }
}
