using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool Condition = true;
            int error = 0, aux = 0, size = 0;
            int[] myArray = new int[1];
            Random myObject = new Random();
            do
            { 
                if ((aux < 1000))
                {
                    myArray[size] = myObject.Next(0, 5);  
                    size++; 
                  //------------------------
                    if (myArray[size] == 4) { error++; } else {error = 0; }

                    Array.Resize(ref myArray, myArray.Length + 1); 
                }
                else { Condition = false; Array.Resize(ref myArray, myArray.Length - 1); }
            }
            while (Condition == true);
        }
    }
}
