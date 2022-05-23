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
        public Persona() { }
        public void getData()
        {
            Console.WriteLine($"{Name} TIENE {Age} AÑOS Y SU NUMERO DE DOCUMENTO ES {Dni}");
        }
        public void setData(string name, int age, int dni)
        {
            Name = name;
            Age = age;
            Dni = dni;
        }
        public bool isAdult()
        {
            if (Age > 18) return true;
            return false;
        }
    }
}

