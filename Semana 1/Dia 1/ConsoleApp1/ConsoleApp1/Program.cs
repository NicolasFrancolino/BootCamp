using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("INSERT NUMBER:");
            try
            {
                int _dataNumber = Convert.ToInt32(Console.ReadLine());

                if (_dataNumber >= 0)
                {
                    int _Number = 0;
                 for (int i = _dataNumber; i < _dataNumber +100; i++){ _Number+= i; }
                    Console.Clear(); Console.WriteLine($"NUMBER  ADDED 100 TIMES IS:{_Number}");
                }else { Console.Clear(); Console.WriteLine("NULL DATA TYPE");}      
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("NULL DATA TYPE");
            }
            Console.ReadKey();
        }
    }
}

