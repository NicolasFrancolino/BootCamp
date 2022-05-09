using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona obj = new Persona("Lucas", 32);
            Console.WriteLine($"{obj.Nombre} ES MAYOR DE EDAD:{obj.esMayor()}");
            Console.ReadKey();
        }
    }
    public partial class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
    public partial class Persona

    {
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
    public static class esMayorEXtencion
    {
        public static bool esMayor(this Persona abc)
        {

            if (abc.Edad > 18) return true;
            return false;
        }

    }
}
