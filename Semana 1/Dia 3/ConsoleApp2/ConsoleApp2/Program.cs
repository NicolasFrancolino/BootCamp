using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void organizedArray(int[] Array)
        {
            int aux = 0;
            for (int i = Array.GetLowerBound(0); i <= Array.GetUpperBound(0); i++)
            {
                for (int j = Array.GetLowerBound(0); j <= Array.GetUpperBound(0); i++)
                {
                    if (Array[i] > Array[j])
                    {
                        aux = Array[i];
                        Array[j] = Array[i];
                        Array[j] = aux;
                        
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" tu Array :");
            foreach (int i in Array)
            {
                Console.Write($"{Array[i]}|");
            }
            
        }
        static void _loadArray(int[] myArray)
        {
            bool Condition = true;
           int  size = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                int aux = Convert.ToInt32(Console.ReadLine());
                if (aux > -1) { 
                    myArray[size] = aux; 
                    size++; 
                    Array.Resize(ref myArray, myArray.Length + 1); 
                }
                else { 
                    Condition = false; 
                    Array.Resize(ref myArray, myArray.Length - 1); 
                }
            }
            while (Condition == true);


        }
        static void Main(string[] args)
        {
            int[] myArray = new int[1];
           /* Console.Write("INGRESE TAMAÑO DEL ARRAY:");
            int size = Convert.ToInt32(Console.ReadLine());*/
            _loadArray(myArray);
            organizedArray(myArray);
            Console.ReadKey();
        }
    }
}
