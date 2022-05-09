using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola<string> marcas = new Cola<string>();
            marcas.Encolar("Audi");
            marcas.Encolar("Opel");
            marcas.Encolar("BMW");


            Console.WriteLine($"La primera marca es {marcas.Desencolar()}"); 
            Console.WriteLine($"La primera marca (otra vez) es {marcas.Desencolar()}"); 
            Console.WriteLine($"La segunda marca es {marcas.Desencolar()}"); 
            Console.ReadLine();
        }
    }
    public class Cola<T>
    {
        Queue<T> cola = new Queue<T>();
        public void  Encolar(T obj)
        {
            cola.Enqueue(obj);   
        }
        public T Desencolar() => cola.Dequeue();
        public void Show()
        {
            foreach (T obj in cola)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
