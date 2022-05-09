using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Facturas obj = new Facturas();
            List<Facturas> listafacturas = new List<Facturas>();
            listafacturas.Add(new Facturas { Type = "a", Value = 20 });
            listafacturas.Add(new Facturas { Type = "b", Value = 60 });
            listafacturas.Add(new Facturas { Type = "c", Value = 10 });
            listafacturas.Add(new Facturas { Type = "a", Value = 100 });
            listafacturas.Add(new Facturas { Type = "b ", Value = 20 });
            listafacturas.Add(new Facturas { Type = "c", Value = 50 });
            listafacturas.Add(new Facturas { Type = "a", Value = 2 });

            foreach (Facturas p in listafacturas)
            {
                Console.WriteLine($"Factura: {obj.Type} por monto de:{obj.Value}");
            }
            Console.ReadKey();
        }
    }
    public class Facturas
    {
        public string Type { get; set; }
        public int Value { get; set; }
 
    }
}
