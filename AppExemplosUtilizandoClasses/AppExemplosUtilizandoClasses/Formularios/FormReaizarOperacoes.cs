using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemplosUtilizandoClasses.RegrasDeNegocio;

namespace AppExemplosUtilizandoClasses.Formularios
{
    public partial class FormReaizarOperacoes : Form
    {
        public FormReaizarOperacoes()
        {
            InitializeComponent();
            //desabilitando as caixas de textos e o botão calcular
            cbOperacao.Enabled = false;
            txtValor1.Enabled = false;
            txtValor2.Enabled = false;
            txtTotal.Enabled = false;
            btCalcular.Enabled = false;
            
            //selecionado o botão novo
            btNovo.Select();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            //limpar e habilitar as caixas de textos e o botão calcular
            cbOperacao.Enabled = true;
            txtValor1.Enabled = true;
            txtValor2.Enabled = true;
            txtTotal.Enabled = true;
            btCalcular.Enabled = true;
            txtValor1.Clear();
            txtValor2.Clear();
            txtTotal.Clear();

            //desabilitanso o botão novo
            btNovo.Enabled = false;
        }

        private void cbOperacao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor1.Select();
            }
        }

        private void txtValor1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor2.Select();
            }
        }

        private void txtValor2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCalcular.Select();
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //armazenando dentre da variavel opcao a posicao do vetor escolhido na combo box
            int opcao = cbOperacao.SelectedIndex;
            //declarando meu objeto para acessar a classe das operações
            Operacoes calcular = new Operacoes();
            //armazenando dentro das variaveis da classe por meio do objeto, os valores entrados nas text box
            calcular.valor1 = Convert.ToDouble(txtValor1.Text);
            calcular.valor2 = Convert.ToDouble(txtValor2.Text);
          
            //estrutura do switch para chamar a função confome o item selecionado na combo box
            switch (opcao)
            {
                case 0:
                    calcular.Somar();
                    break;
                case 1:
                    calcular.Subtrarir();
                    break;
                case 2:
                    calcular.Dividir();
                    break;
                case 3:
                    calcular.Multiplicar();
                    break;
                case 4:
                    calcular.Potenciacao();
                    break;
            }
            txtTotal.Text = calcular.resultado.ToString();
            btNovo.Enabled = true;
        }
    }
}
