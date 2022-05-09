using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void _Area(int height, int sideA, int sideB)
        {
            int area = height * ((sideA + sideB) / 2);
            Console.WriteLine($"EL AREA DEL RECTANGULO ES: {area}");         
        }  
        static void _loadAndShow()
        {
            Console.Write("INGRESE LA ALTURA:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("INGRESE EL LADO A:");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.Write("INGRESE EL LADO B:");
            int sideB = Convert.ToInt32(Console.ReadLine());
            _Area(height, sideA, sideB);

        }
        static void Main(string[] args)
        {
            _loadAndShow();
            Console.ReadKey();
        }
    }
}
