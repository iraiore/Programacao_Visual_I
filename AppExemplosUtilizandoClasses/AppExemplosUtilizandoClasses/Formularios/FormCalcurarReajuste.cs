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
    public partial class FormCalcurarReajuste : Form
    {
        public FormCalcurarReajuste()
        {
            InitializeComponent();
            //ao iniciar  a o formulario os campos e botoes (com excessão do botao novo) aparece desabilitados
            txtSalarioAtual.Enabled = false;
            txtPercentualReajuste.Enabled = false;
            txtSalarioReajustado.Enabled = false;
            btCalcularReajuste.Enabled = false;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            //limpando todas as textbox
            txtSalarioAtual.Clear();
            txtPercentualReajuste.Clear();
            txtSalarioReajustado.Clear();
            
            //habilitando todos as textbox e o botão calcular
            txtSalarioAtual.Enabled = true;
            txtPercentualReajuste.Enabled = true;
            txtSalarioReajustado.Enabled = true;
            btCalcularReajuste.Enabled = true;

            //selecionado o a primeira textbox a ser preenchida
            txtSalarioAtual.Select();
            //desabilitando o botão novo
            btNovo.Enabled = false;
        }

        private void txtSalarioAtual_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPercentualReajuste.Select();
            }
        }

        private void txtPercentualReajsute_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCalcularReajuste.Select();
            }
        }

        private void btCalcularReajuste_Click(object sender, EventArgs e)
        {
            //criando o objeto para acessar a classe de Reajustar o salário
            ReajusteSalario reajustar = new ReajusteSalario();
            
            //colocando os valores dentro das variaveis da classe por meio do objeto
            reajustar.SalaraioAtual = Convert.ToDouble(txtSalarioAtual.Text);
            reajustar.PercentualReajuste = Convert.ToDouble(txtPercentualReajuste.Text);
            
            //chamando a função da classe para calcular o reajuste. Não é necessário passar parâmetros
            reajustar.CalcularReajusteSalarial();

            //colocando o resultado da função da classe dentro da textbox de salario reajustado do formulário
            txtSalarioReajustado.Text = reajustar.SalarioReajustado.ToString();

            //ativando o botão novo e desativando o botao calcular
            btCalcularReajuste.Enabled = false; 
            btNovo.Enabled = true;
            btNovo.Select();
        }
    }
}
