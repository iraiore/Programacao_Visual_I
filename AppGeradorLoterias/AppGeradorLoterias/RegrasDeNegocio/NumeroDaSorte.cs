using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGeradorLoterias.RegrasDeNegocio
{
    internal class NumeroDaSorte
    {
        public int Numero { get; set; }
        public string Tipo
        {
            get
            {
                string resultado = " ";
                if (Numero % 2 == 0) resultado = "Par";
                if (Numero % 2 != 0) resultado = "Impar";
                return resultado;
            }
        }
    }
}
