using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplosUtilizandoClasses.RegrasDeNegocio
{
    internal class Operacoes
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }
        public double resultado {get; set; }

        public void Somar()
        {
            resultado = valor1 + valor2;
        }
        public void Subtrarir()
        {
            resultado = valor1 - valor2;
        }
        public void Multiplicar()
        {
            resultado = valor1 * valor2;
        }
        public void Dividir()
        {
            resultado = valor1 / valor2;
        }
        public void Potenciacao()
        {
            resultado = Math.Pow(valor1,valor2);
        }


    }
}
