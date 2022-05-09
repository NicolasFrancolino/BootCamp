using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _plus = 0, count = 0;
            do
            {
                Console.Write("INSERT NUMBER:");
                int _num = Convert.ToInt32(Console.ReadLine()); 
                _plus+= _num;
                count++;
                Console.Clear();    

            }while(_plus < 150);
            Console.WriteLine($"ADDED: {_plus} | AMOUNT: {count}");
            Console.ReadKey();
        }
    }
}
