using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParPrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double type, t_Type;
            Queue myQueue = new Queue();
            int count = 0;
            try
            {
            for (byte i = 0; i < 5; i++)
            {
                count++;
                Console.Write($"Ingrese nuemro {count}:");
                type = int.Parse(Console.ReadLine());
                myQueue.Enqueue(type) ;
                Console.Clear();
            }
            Console.Write($"La cola es: ");
            for (byte i = 0; i < 5; i++)
            {
                t_Type = (double)myQueue.Dequeue();
                Console.Write($"{t_Type}|"); 
            }

            }
            catch (FormatException)
            {
              Console.Clear();
              Console.WriteLine("NULL DATA TYPE");  
            }
            Console.ReadKey();
        }
    }
}
