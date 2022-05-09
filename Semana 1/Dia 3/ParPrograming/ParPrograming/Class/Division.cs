using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParPrograming.Class
{
    public class Division : Calculo
    {
        public void Calcular()
        {
            Resultado_div = (double)Valor1 / (double)Valor2;
        }
    }
}
