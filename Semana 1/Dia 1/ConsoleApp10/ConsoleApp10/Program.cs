using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void _article()
        {
            int  size = 0, aux = 0 ;
            double price  = 0 ; 
            int[] myArray = new int[8];
            Random myObject = new Random();
            for (int i = 1; i < myArray.Length; i++)
            {
                
                
               
                if (i == 1) myArray[size] = myObject.Next(1,10);

                if (i == 2) myArray[size] = myObject.Next(1,21);

                if (i == 3) myArray[size] = myObject.Next(1,22);

                if (i == 4)
                {

                    myArray[size] = myObject.Next(1,10);
                        aux += myArray[size];
                }

                if (i == 5)
                {

                    myArray[size] = myObject.Next(1, 10);
                        aux += myArray[size];
                }
                if (i == 6)
                { 

                    myArray[size] = myObject.Next(1, 10);
                        aux += myArray[size];
                }

                if (i == 7)
                {

                    myArray[size] = myObject.Next(1, 10);
                        aux+=myArray[size];
                }
                        
                
            }
            price = ((aux * myArray[1])/100)*3.5;
            Console.WriteLine($"ARTICULO {myArray[1]} | PRECIO: {price}");

        }
        static void Main(string[] args)
        {
            _article();
            Console.ReadKey();
        }
    }
}
