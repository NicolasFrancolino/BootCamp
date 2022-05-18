using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Categoria
    {
        public Categoria(int tipo, double aumento)
        {
            Tipo = tipo;
            Aumento = aumento;
        }
        public Categoria()
        {

        }

        public int Tipo { get; set; }
        public double Aumento { get; set; }
        
    }
}
