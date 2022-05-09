using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Estudiante : Persona
    {
        
        public  void Estudiar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ESTOY ESTUDIANDO");
        }
        public  void verEdad()
        {
            //Console.WriteLine($"MI EDAD ES:{}");
        }
    }
}
