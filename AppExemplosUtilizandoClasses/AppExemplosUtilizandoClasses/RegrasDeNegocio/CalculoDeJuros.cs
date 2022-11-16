using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplosUtilizandoClasses.RegrasDeNegocio
{
    internal class CalculoDeJuros
    {
        public double Montante { get; set; }
        public double Capital { get; set; }
        public double Taxa { get; set; }
        public double Tempo { get; set; }

        public void CalularMontante()
        {
            Taxa = Taxa / 100;
            Montante = Capital * (1 + Taxa * Tempo);
        }
        public void CalularCapital()
        {
            Taxa = Taxa / 100;
            Capital = Montante / (1 + Taxa * Tempo);
        }
        public void CalularTaxa()
        {
            Taxa = (Montante - Capital) / (Capital * Tempo)*100;
        }
        public void CalularTempo()
        {
            Taxa = Taxa / 100;
            Tempo = (Montante - Capital) / (Capital * Taxa);
        }
    }
}
