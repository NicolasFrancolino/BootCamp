using ConsoleApp3.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("lucas", 35336675);
            Cuenta obj = new Cuenta(persona);
            obj.Show();

        }
     /*     
           class Cuenta : Persona
        {
            public double Cantidad { get; set; }
            public Persona Titular { get; set; }

            public Cuenta(Persona titular, double cantidad)
            {
                Titular = titular;
                Cantidad = cantidad;
            }

            public void mostrar()
            {
                Console.WriteLine("el nombre de esta persona es " + Nombre);
                Console.WriteLine("la edad es " + Edad);
                Console.WriteLine("el Dni es " + Dni);
            }*/


    }
 }

