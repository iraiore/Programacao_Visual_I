using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplosUtilizandoClasses.RegrasDeNegocio
{
    internal class ReajusteSalario
    {
        public double SalaraioAtual { get; set; } 
        public double PercentualReajuste { get; set; }
        public double SalarioReajustado { get; set; }
    
        public void CalcularReajusteSalarial()
        {
            PercentualReajuste = PercentualReajuste / 100;
            SalarioReajustado = SalaraioAtual * (1 + PercentualReajuste);
        }
    }
}
