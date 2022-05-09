using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        int result = 0, size = 0;
        static void Main(string[] args)
        {
            Program re = new Program();
            re.methodRecursive(buildArray(), 5);
            Console.WriteLine($"ARRAY SUMADO:{re.result}");
            Console.ReadKey();


        }
        void methodRecursive(int[] Array, int i)
        {  
            
            if (i > 0)
            {
               result+=Array[size++];
               methodRecursive(Array, i - 1);
            }
        }
        static int[] buildArray()
        {
            int[] buildArray = loadArray();
            return buildArray;
        }
        static int[] loadArray()
        {
            int[] defaultArray = new int[5];

            for (int col = 0; col < defaultArray.Length; col++)
            {
                Console.Clear();
                Console.Write($"INGRESE DATO:");
                string dataArray = Console.ReadLine();
                defaultArray[col] = int.Parse(dataArray);

            }
            return defaultArray;
        }
    }
}
