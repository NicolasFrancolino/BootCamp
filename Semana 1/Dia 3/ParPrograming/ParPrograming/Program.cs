
using ParPrograming.Clases;
using ParPrograming.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParPrograming
{
     public class Program
    {
            static void Main(string[] args)
            {
                bool error = false;
                do
                {
                    int selector;
                    int numero1 = 0;
                    int numero2 = 0;
                    try
                    {
                        Console.WriteLine("\nCalcular con clase");
                        Console.WriteLine("Sumar = 1");
                        Console.WriteLine("Restar = 2");
                        Console.WriteLine("Dividir = 3");
                        Console.WriteLine("Multiplicar = 4");
                        Console.WriteLine("Salir = 5");
                        selector = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (selector)
                        {

                            case 1: //Caso uno es suma

                                Suma suma1 = new Suma();
                                Console.WriteLine("Ingrese primer valor:");
                                numero1 = Int32.Parse(Console.ReadLine());
                                suma1.Valor1 = numero1;
                                Console.WriteLine("Ingrese segundo valor:");
                                numero2 = Int32.Parse(Console.ReadLine());
                                suma1.Valor2 = numero2;
                                suma1.Calcular();
                                Console.WriteLine("La suma de " + suma1.Valor1 + " y " + suma1.Valor2 + " es " + suma1.Resultado);
                                error = true;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2: //resta
                                Resta resta1 = new Resta();
                                Console.WriteLine("Ingrese primer valor:");
                                numero1 = Int32.Parse(Console.ReadLine());
                                resta1.Valor1 = numero1;
                                Console.WriteLine("Ingrese segundo valor:");
                                numero2 = Int32.Parse(Console.ReadLine());
                                resta1.Valor2 = numero2;
                                resta1.Calcular();
                                Console.WriteLine("La resta de " + resta1.Valor1 + " y " + resta1.Valor2 + " es " + resta1.Resultado);
                                error = true;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3: //division
                                Division division1 = new Division();
                                Console.WriteLine("Ingrese primer valor:");
                                numero1 = Int32.Parse(Console.ReadLine());
                                division1.Valor1 = numero1;
                                Console.WriteLine("Ingrese segundo valor:");
                                numero2 = int.Parse(Console.ReadLine());
                                division1.Valor2 = numero2;
                                division1.Calcular();
                                Console.WriteLine("La division de " + division1.Valor1 + " y " + division1.Valor2 + " es " + division1.Resultado_div);
                                error = true;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 4: //multiplicacion
                                Multiplicacion multiplicacion1 = new Multiplicacion();
                                Console.WriteLine("Ingrese primer valor:");
                                numero1 = Int32.Parse(Console.ReadLine());
                                multiplicacion1.Valor1 = numero1;
                                Console.WriteLine("Ingrese segundo valor:");
                                numero2 = Int32.Parse(Console.ReadLine());
                                multiplicacion1.Valor2 = numero2;
                                multiplicacion1.Calcular();
                                Console.WriteLine("La multiplicacion de " + multiplicacion1.Valor1 + " y " + multiplicacion1.Valor2 + " es " + multiplicacion1.Resultado);
                                error = true;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 5:
                                Console.Clear();
                                error = false;
                                break;
                        }
                    }
                    catch (FormatException )
                    {
                        Console.Clear();
                        Console.WriteLine("Tipo de dato no permitido");
                        error = true;
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                while (error == true);


            }
        }
    }


