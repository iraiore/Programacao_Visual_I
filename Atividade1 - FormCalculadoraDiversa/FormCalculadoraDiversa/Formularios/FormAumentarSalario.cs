using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculadoraDiversa.Formularios
{
    public partial class FormAumentarSalario : Form
    {
        public FormAumentarSalario()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double salario = 0, Percent = 0, SalarioReajsutado = 0;
            salario = Convert.ToDouble(txtSalarioAtual.Text);
            Percent = Convert.ToDouble(txtPercentAjuste.Text);
            SalarioReajsutado = salario * (1 + Percent / 100);
            txtResultado.Text = SalarioReajsutado.ToString();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtSalarioAtual.Clear();
            txtPercentAjuste.Clear();
            txtResultado.Clear();
            txtSalarioAtual.Select();
        }


        private void txtSalarioAtual_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtSalarioAtual.Text.All(char.IsDigit))
            {
                MessageBox.Show("Digite apenas número", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPercentAjuste_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtPercentAjuste.Text.All(char.IsDigit))
            {
                MessageBox.Show("Digite apenas número", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
