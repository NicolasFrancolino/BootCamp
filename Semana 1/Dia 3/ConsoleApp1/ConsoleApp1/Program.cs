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
            int[] myArray = _loadArray();
            Console.Clear();
            _organizedArray(myArray);
            for (int col = 0; col < 5; col++)
            {
                Console.WriteLine($" ALUMNO:{myArray[col]}");
               /* Console.Write("SU NOTAS:");
                for (int row = 0; row < 2; row++)
                {
                    Console.Write($"{myArray[col]}|");

                }
                Console.WriteLine("");*/

            }
            Console.ReadKey();
        }
        static int[] _loadArray()
        {
            int[] myStudentsArray = new int[2];

            for (int col = 0; col < 5; col++)
            {
                Console.Clear();
                Console.Write($"INGRESE ALUMNO:");
                string student = Console.ReadLine();
                myStudentsArray[col] = int.Parse(student);
                /*for (int row = 0; row < 2; row++)
                {
                    Console.Write($"INGRESE NOTA:");
                    string score = Console.ReadLine();
                    myStudentsArray[col, row] = int.Parse(score);
                }*/
            }
            return myStudentsArray;
        }
        static int[] _organizedArray(int[] Array)
        {
            int[] myArray = new int[2];
            int aux;

            for (int i = 0; i < myArray[i]; i++)
            {
                if (myArray[i] > Array[i])
                {
                    aux = myArray[i];
                    myArray[i] = Array[i];
                    myArray[i] = aux;
                }
            }
            return myArray;
        }
    }
}
 

