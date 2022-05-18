using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Cliente
    {
        public Cliente(int id, string nombre, string articulo)
        {
            Id = id;
            Nombre = nombre;
            Articulo = articulo;
        }
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Articulo { get; set; }
        
        //Erro |no se cumple el principio de responsabilidad unica 
        public static string ComprarArticulo(string articulo) => articulo;
        
        public  void setNombre(string nombre){Nombre = nombre;}
    }
    // Solucion cumpliendo el principio.
    public class Articulo
    {
        public Articulo(int id, string articulo1)
        {
            Id = id;
           Type_articulo = articulo1;
        }

        public int Id { get; set; }
        public string Type_articulo { get; set; }

        public static string ComprarArticulo(string articulo) => articulo;
    }

}
