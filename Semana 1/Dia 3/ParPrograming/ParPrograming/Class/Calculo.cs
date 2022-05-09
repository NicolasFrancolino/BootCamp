using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParPrograming
{
    public class Calculo
    {
        protected int valor1;
        protected int valor2;
        protected int resultado;
        protected double resultado_div;

        public int Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }

        public int Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }

        public int Resultado
        {
            protected set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
        public double Resultado_div
        {
            protected set
            {
                resultado_div = value;
            }
            get
            {
                return resultado_div;
            }
        }
    }
}

