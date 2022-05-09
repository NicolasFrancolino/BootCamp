using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("lucas");
            list.Add("fernando");
            list.Add("guillermo");
            list.Add("francisco");
            list.Add("martin");
            Console.WriteLine("A QUIEN DESEA ELIMINAR:");
            string data = Console.ReadLine();
            deleteElement(list,data);
          

            Console.Write($"EL DATOS INGRESADOS:");
            for (int i = 0; i < 5; i++)
            { 
                Console.Write(list[i]);
            }
            Console.ReadKey();
        }
        static void deleteElement(List<string> list, string data)
        {
            for (int i = 0; i < 5; i++)
            {
                if (list[i] == data)
                {
                    list.Remove(data);
                }

            }  
        }
    }
}
