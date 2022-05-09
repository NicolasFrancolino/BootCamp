using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
         static void _action(int type){ 
            Console.Write($"AUMENTO DE SALARIO:{(type/100)*8}\n");
            Console.Write($"DESCUENTO POR SERVICIOS:{(type/100)*2.5}");        
        }
        static void Main(string[] args)
        {
            Console.Write("INGRESE SALARIO:");
            int salary = Convert.ToInt32(Console.ReadLine());
            _action(salary);
            Console.ReadKey();  
        }
    }
}
