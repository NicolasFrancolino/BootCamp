using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona obj = new Persona("Lucas", 32);
            Console.WriteLine($"NOMBRE DE LA PERSONA:{obj.getNombre()}");
            Console.WriteLine($"EDAD DE LA PERSONA:{obj.getEdad()}");
            Console.ReadKey();
        }
    }
    public partial class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
    }
    public partial class Persona
    {
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public int getEdad() => Edad;
        public string getNombre() => Nombre;
        

    }
}
