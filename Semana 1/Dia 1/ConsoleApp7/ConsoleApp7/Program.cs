using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Calc(int t_type)
        {
            t_type   = t_type   % 60;
            int minutes = t_type / 60;
            int hours = minutes / 60;
            Console.WriteLine($"Hora: {hours} | minutos: {minutes}  | {t_type}");
            
        }
        static void Main(string[] args)
        {
            Console.Write("INGRESE SEGUNDOS:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Calc(seconds);
            Console.ReadKey(); 
        }
    }
}
