using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7.Models;

namespace ConsoleApp7.Class
{
    public class Eiffel : IEiffel
    {
        

        public Eiffel(int dato)
        {
            
        }
        public void Elemento()
        {

        }
        public void Eliminar()
        {

        }


        public void Insercion()
        {
            Console.WriteLine("INGRESE DATO:");
            Dato = Convert.ToInt32(Console.ReadKey());
        }
    }
}
