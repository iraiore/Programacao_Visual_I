using AppGeradorLoterias.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormMegaSena : Form
    {
        List<NumeroDaSorte> listaNumeros = new List<NumeroDaSorte>();
        public FormMegaSena()
        {
            InitializeComponent();
            tabela.AutoGenerateColumns = false;
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            btGerar.Enabled = false;
            listaNumeros.Clear();
            int numero = 0;
            int contador = 0;
            Random random = new Random();// gerar numeros aleatorios
            while (contador < 6)
            {
                numero = random.Next(1, 61);
                if (listaNumeros.Count(n => n.Numero == numero) == 0)
                {
                    NumeroDaSorte num = new NumeroDaSorte();
                    num.Numero = numero;
                    listaNumeros.Add(num);
                    contador++;
                }

            }// fim do laço
            tabela.DataSource = listaNumeros.OrderBy(n => n.Numero).ToList();
            int qtdPar = listaNumeros.Count(p => p.Tipo == "Par");
            int qtdImpar = listaNumeros.Count(q => q.Tipo == "Impar");
            lbPar.Text = "PARES: " + qtdPar;
            lbImpar.Text = "IMPARES: " + qtdImpar;
            Classificar(qtdPar, qtdImpar);
        }
        public void Classificar(int qtdPar, int qtdImpar)
        {
            if (qtdPar == 3 && qtdImpar == 3) lbClass.Text = "Classifica: Muito Alto";
            if (qtdPar == 4 && qtdImpar == 2) lbClass.Text = "Classifica: Alto";
            if (qtdPar == 2 && qtdImpar == 4) lbClass.Text = "Classifica: Média";
            if (qtdPar == 5 && qtdImpar == 1) lbClass.Text = "Classifica: Baixo";
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            btGerar.Enabled = true;
            btLimpar.Enabled = true;
            listaNumeros.Clear();
            tabela.DataSource = listaNumeros;
        }

        private void btGerar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLimpar.Select();
            }
        }

        private void btLimpar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btGerar.Focus();
            }
        }
    }
}
