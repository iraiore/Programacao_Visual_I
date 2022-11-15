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
    public partial class FormCalcularFigura : Form
    {
        public FormCalcularFigura()
        {
            InitializeComponent();
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opc = cbOpcao.SelectedIndex;
            switch (opc)
            {
                case 0:
                    lbValor1.Text = "Diagonal Maior: ";
                    lbValor2.Text = "Diagonal Menor: ";
                    lbResultado.Text = "Área do Losango: ";
                    lbValor3.Visible = false;
                    txtValor3.Visible = false;
                    break;
                case 1:
                    lbValor1.Text = "Base (b): ";
                    lbValor2.Text = "Altura (h): ";
                    lbResultado.Text = "Área do retângulo: ";
                    lbValor3.Visible = false;
                    txtValor3.Visible = false;
                    break;
                case 2:
                    lbValor1.Text = "Base maior (B): ";
                    lbValor2.Text = "Base menor (b): ";
                    lbValor3.Text = "Altura (h): ";
                    lbResultado.Text = "Área do trapézio: ";
                    break;
                case 3:
                    lbValor1.Text = "Base (b): ";
                    lbValor2.Text = "Altura (h): ";
                    lbResultado.Text = "Área do trinângulo retângulo: ";
                    lbValor3.Visible = false;
                    txtValor3.Visible = false;
                    break;
                case 4:
                    lbValor1.Text = "Lado (a): ";
                    lbValor2.Visible = false;
                    txtValor2.Visible = false;
                    lbResultado.Text = "Área do trinângulo retângulo: ";
                    lbValor3.Visible = false;
                    txtValor3.Visible = false;
                    break;
            }

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int opc = cbOpcao.SelectedIndex;
            double valor1 = 0, valor2 = 0,valor3 = 0, resultado = 0; ;
            switch (opc)
            {
                case 0:
                    valor1 = Convert.ToDouble(txtValor1.Text);
                    valor2 = Convert.ToDouble(txtValor2.Text);
                    resultado = (valor1 * valor2)/2;
                    txtResultado.Text = resultado.ToString("F2");
                    break;
                case 1:
                    valor1 = Convert.ToDouble(txtValor1.Text);
                    valor2 = Convert.ToDouble(txtValor2.Text);
                    resultado = (valor1 * valor2);
                    txtResultado.Text = resultado.ToString("F2");
                    break;
                case 2:
                    valor1 = Convert.ToDouble(txtValor1.Text);
                    valor2 = Convert.ToDouble(txtValor2.Text);
                    valor3 = Convert.ToDouble(txtValor3.Text);
                    resultado = (valor1 + valor2)*valor3/2;
                    txtResultado.Text = resultado.ToString("F2");
                    break;
                case 3:
                    valor1 = Convert.ToDouble(txtValor1.Text);
                    valor2 = Convert.ToDouble(txtValor2.Text);
                    resultado = (valor1 * valor2) / 2;
                    txtResultado.Text = resultado.ToString("F2");
                    break;
                case 4:
                    valor1 = Convert.ToDouble(txtValor1.Text);
                    resultado = Math.Sqrt(3)*(valor1*valor1)/4;
                    txtResultado.Text = resultado.ToString("F2");
                    break;
            }

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor3.Clear();
            txtResultado.Clear();
            txtValor1.Select();
        }

        private void txtValor1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtValor1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Digite apenas número","ADS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtValor2_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtValor2.Text.All(char.IsDigit))
            {
                MessageBox.Show("Digite apenas número", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtValor3_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtValor3.Text.All(char.IsDigit))
            {
                MessageBox.Show("Digite apenas número", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
