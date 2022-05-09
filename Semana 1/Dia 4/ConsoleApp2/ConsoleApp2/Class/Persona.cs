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
        public void Show()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Age}");
            Console.WriteLine($"{Dni}");
        }
        public bool isAdult()
        {
            if (Age > 18) return true;
            return false;
        }
    }
}

