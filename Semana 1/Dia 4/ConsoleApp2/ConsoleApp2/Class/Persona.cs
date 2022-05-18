using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp2.Models;

namespace ConsoleApp2.Class
{
    class Persona : ModeloPersona 
    {

        public Persona(string name , int age , int dni)
        {
            Name = name;
            Age = age;
            Dni = dni;
        }
        public void getData()
        {
            Console.Write($"Nombre: {Name}, edad:{Age}, numero de doc: {Dni}");
        }
        public bool isAdult()
        {
            if (Age > 18) return true;
            return false;
        }
    }
}

