using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo obj = new Rectangulo(14.5,8.5);
            Console.WriteLine($"LA SUPERFICIE DEL RECTANGULO ES:{obj.Superficie()}");
            Console.WriteLine($"EL PERIMETRO DEL RECTANGULO ES:{obj.Perimetro()}");
            Console.ReadKey();
        }
    }
    public partial class Rectangulo
    {
        public double Largo { get; set; }
        public double Altura { get; set; }
    }
    public partial class Rectangulo
    {
        public Rectangulo(double largo , double altura)
        {
            Largo = largo;
            Altura = altura;
        }
        public double Superficie() => Largo * Altura;
        public double Perimetro() => (Largo + Altura)*2;    
    }

}
