using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary = 0, mouns = 0 ; 
            double increase = 0, total;
            Console.Write("INGRESE SALARIO:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("INGRESE CANTIDAD DE MESES TRABAJADOS:");
            mouns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"SALARIO ACTUAL:{salary}"); 
            if (mouns == 10){
                increase = (salary/100)*25;
                total = ((salary-increase) * 6) + (salary * 4);
                Console.WriteLine($"SALARIO TOTAL EN LOS PRIMEROS 6 MESES:{salary-increase}");

                Console.WriteLine($"SALARIO TOTAL DE LOS 10 MESES:{total}");
            }
            Console.ReadKey();  
        }
    }
}
