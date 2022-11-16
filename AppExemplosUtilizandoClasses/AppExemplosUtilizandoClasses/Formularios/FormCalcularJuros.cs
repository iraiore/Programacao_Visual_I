using AppExemplosUtilizandoClasses.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplosUtilizandoClasses.Formularios
{
    public partial class FormCalcularJuros : Form
    {
        public FormCalcularJuros()
        {
            InitializeComponent();
            //inativando as caixas de texto e botões
            cbOpcao.Enabled = false;
            txtCapital.Enabled = false;
            txtMontante.Enabled = false;
            txtTaxa.Enabled = false;
            txtTempo.Enabled = false;
            btCalcular.Enabled = false;

            //selecionando o botão novo
            btNovo.Select();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            //Limpando e ativanndo as caixas de texto e botões
            txtCapital.Clear();
            txtMontante.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            btCalcular.Enabled = true;
            cbOpcao.Enabled = true;
            txtCapital.Enabled = true;
            txtMontante.Enabled = true;
            txtTaxa.Enabled = true;
            txtTempo.Enabled = true;
            btCalcular.Enabled = true;

            //inativando o botão novo
            btNovo.Enabled = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //armazendno dentro da variavel opção o número do vetor da combobox
            int opcao = cbOpcao.SelectedIndex;
            //estanciando o objeto da classe Calculo De Juros
            CalculoDeJuros objeto = new CalculoDeJuros();
            //armazenado os valores das textbox na classe
            /*objeto.Montante = Convert.ToDouble(txtMontante.Text);
            objeto.Capital = Convert.ToDouble(txtCapital.Text);
            objeto.Taxa = Convert.ToDouble(txtTaxa.Text);
            objeto.Tempo = Convert.ToDouble(txtTempo.Text);*/

            switch (opcao)
            {
                case 0:
                    objeto.Capital = Convert.ToDouble(txtCapital.Text);
                    objeto.Taxa = Convert.ToDouble(txtTaxa.Text);
                    objeto.Tempo = Convert.ToDouble(txtTempo.Text);
                    objeto.CalularMontante();
                    txtMontante.Text = objeto.Montante.ToString();
                    break;
                case 1:
                    objeto.Montante = Convert.ToDouble(txtMontante.Text);
                    objeto.Taxa = Convert.ToDouble(txtTaxa.Text);
                    objeto.Tempo = Convert.ToDouble(txtTempo.Text);
                    objeto.CalularCapital();
                    txtCapital.Text = objeto.Capital.ToString();    
                    break;
                case 2:
                    objeto.Montante = Convert.ToDouble(txtMontante.Text);
                    objeto.Capital = Convert.ToDouble(txtCapital.Text);
                    objeto.Tempo = Convert.ToDouble(txtTempo.Text);
                    objeto.CalularTaxa();
                    txtTempo.Text = objeto.Taxa.ToString();
                    break;
                case 3:
                    objeto.Montante = Convert.ToDouble(txtMontante.Text);
                    objeto.Capital = Convert.ToDouble(txtCapital.Text);
                    objeto.Taxa = Convert.ToDouble(txtTaxa.Text);
                    objeto.CalularTempo();
                    txtTempo.Text = objeto.Tempo.ToString();
                    break;
            }
            btNovo.Enabled = true;
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //armazendno dentro da variavel opção o número do vetor da combobox
            int opcao = cbOpcao.SelectedIndex;
            switch (opcao)
            {
                case 0:
                    txtMontante.ReadOnly = true;
                    txtMontante.BackColor = Color.LightGoldenrodYellow;
                    txtCapital.ReadOnly = false;
                    txtCapital.BackColor = Color.White;
                    txtTaxa.ReadOnly = false;
                    txtTaxa.BackColor = Color.White;
                    txtTempo.ReadOnly = false;
                    txtTempo.BackColor = Color.White;
                    break;
                case 1:
                    txtMontante.ReadOnly = false;
                    txtMontante.BackColor = Color.White;
                    txtCapital.ReadOnly = true;
                    txtCapital.BackColor = Color.LightGoldenrodYellow;
                    txtTaxa.ReadOnly = false;
                    txtTaxa.BackColor = Color.White;
                    txtTempo.ReadOnly = false;
                    txtTempo.BackColor = Color.White;
                    break;
                case 2:
                    txtMontante.ReadOnly = false;
                    txtMontante.BackColor = Color.White;
                    txtCapital.ReadOnly = false;
                    txtCapital.BackColor = Color.White;
                    txtTaxa.ReadOnly = true;
                    txtTaxa.BackColor = Color.LightGoldenrodYellow;
                    txtTempo.ReadOnly = false;
                    txtTempo.BackColor = Color.White;
                    break;
                case 3:
                    txtMontante.ReadOnly = false;
                    txtMontante.BackColor = Color.White;
                    txtCapital.ReadOnly = false;
                    txtCapital.BackColor = Color.White;
                    txtTaxa.ReadOnly = false;
                    txtTaxa.BackColor = Color.White;
                    txtTempo.ReadOnly = true;
                    txtTempo.BackColor = Color.LightGoldenrodYellow;
                    break;
            }
        }
    }
}
