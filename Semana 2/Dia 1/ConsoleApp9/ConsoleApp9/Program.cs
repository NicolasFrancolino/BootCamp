using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "hola mundo";
            Console.WriteLine(frase.Mitad());
            Console.WriteLine(frase.Mitad2());
            Console.ReadLine();
        }
    }

    public static class Extension
    {
        public static string Mitad(this string Type_string) => Type_string.Substring(0, Type_string.Length / 2);
        public static string Mitad2(this string Type_string) => Type_string.Substring(Type_string.Length / 2);
    }
}
