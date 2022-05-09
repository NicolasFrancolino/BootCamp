using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER START RANGE:");
            int _startRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER  END RANGE:");
            int _endRange = Convert.ToInt32(Console.ReadLine());
         //---------------------------------------------------------
            int aux = _startRange;
            bool _condition = true;
            do{ if (aux != _endRange) { _startRange = _startRange + 7; aux++; } else { _condition = false; } } while (_condition == true);
         //---------------------------------------------------------
            Console.WriteLine($"NUMBER ADDEC BY 7:{_startRange}");
            Console.ReadKey();
        }
    }
}
