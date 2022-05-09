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
            cuentaCorrinete obj = new cuentaCorrinete("VARELA LUCAS", "PESOS", 10.000);
            Console.WriteLine($"PROPIETARIO DE CUENTA {obj.getPrpietario()} SU SALDO ES DE: {obj.getSaldo()} EN {obj.getMoneda()}" );
            Console.ReadKey();
        }
    }
    public partial class cuentaCorrinete
    {
        public string Moneda { get; set; }
        public string Propietario { get; set; }
        public double Saldo { get; set; }
    }
    public partial class cuentaCorrinete
    {
        public cuentaCorrinete(string propietario, string moneda, double saldo)
        {
            Propietario = propietario;
            Moneda = moneda;
            Saldo = saldo;
        }
        public string getMoneda() => Moneda;
        public string getPrpietario() => Propietario;
        public double getSaldo() => Saldo;
    }
}