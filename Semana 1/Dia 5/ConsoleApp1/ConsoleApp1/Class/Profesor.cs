using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Profesor : Persona
    {
        
        public  void Explicar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ESTOY EXPLICANDO");
        }
    }
}
