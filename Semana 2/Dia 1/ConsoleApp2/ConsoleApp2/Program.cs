using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo obj = new Vehiculo(false,false);
            string state;
            do
            {
                
            Console.Write("START ENGINE = E | ACELERATE = A | BREAKE = B | STOP ENGINE = S: ");
            state = Console.ReadLine();
                if (state == "E")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"START ENGINE:{obj.start()}"); 
                    Console.ReadKey();
                }
                if (state == "A")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ACCELERATING:{obj.start()}"); 
                    Console.ReadKey();
                }
                if (state == "B")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"BREAKING:{obj.start()}"); 
                    Console.ReadKey();
                }
            } while (state == "S");
        }
    }
    public partial class Vehiculo
    {
        public bool Engine { get; set; }
        public bool Speed { get; set; }
    }
    public partial class Vehiculo
    {
        
        public Vehiculo(bool engine, bool speed)
        {
           Engine = engine;
            Speed = speed;
        }
        public bool start() => Engine = true;
        public bool stop () => Engine = false;
        public bool breake() => Engine = false;
        public bool acelerate() => Engine = true;

    }
    
}
