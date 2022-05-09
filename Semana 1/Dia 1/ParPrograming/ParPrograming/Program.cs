using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParPrograming
{
    internal class Program
    {
        /* Dado un numero N cual es el mayor y cual es el menor*/
        static void _ProblemOne()
        {
            Console.WriteLine("Ingrese numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El numero mayor es: {numero + 1}, y el menor {numero - 1}");
            Console.ReadKey();

        }
        /* Ingrese N cantidad de numeros, se pide calcular mayor menor y total*/
        static void _ProblemTwo()
        {
            int max = 0, min = 0, plus = 0;
            Console.Write("Cantidad de numero a ingresar:");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Clear();
                Console.Write("Ingrese numero:");
                int number = Convert.ToInt32(Console.ReadLine()); 
                if(number > max) { max = number;}
                if((number < min)||(min == 0)) { min = number;}
                plus+= number;
            }
            Console.WriteLine($"Numero mayor ingresado: {max}, numero menor:{min}, total {plus}");
        }
        
        static void Main(string[] args)
        {
            _ProblemOne();  
            _ProblemTwo();
            Console.ReadKey();
            
        }
    }
}
