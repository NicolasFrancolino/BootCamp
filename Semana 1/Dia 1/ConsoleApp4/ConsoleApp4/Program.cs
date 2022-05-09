using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER EMPLOYEE NAME:");   
            string name = Console.ReadLine();
            Console.Write("ENTER WORKHOUR VALUE:");
            int _value = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER WORKHOURS:");  
            int _hours = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"EMPLOYEE: {name} | SALARY:{_hours*_value}");
            Console.ReadKey();  
            
        }
    }
}
