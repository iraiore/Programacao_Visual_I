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
    public partial class FormCalcularDesconto : Form
    {
        public FormCalcularDesconto()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double compra = 0, Percentdesconto = 0, valorDesconto = 0;
            compra = Convert.ToDouble(txtValorCompra.Text);
            Percentdesconto = Convert.ToDouble(txtPercentDesconto.Text);
            valorDesconto = compra * (1 - Percentdesconto / 100);
            txtCompraDesconto.Text = valorDesconto.ToString();
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            txtValorCompra.Clear();
            txtPercentDesconto.Clear();
            txtCompraDesconto.Clear();
            txtValorCompra.Select();
        }

        private void txtValorCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtValorCompra.Text.All(char.IsDigit))
            {
                MessageBox.Show("Digite apenas número", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPercentDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtPercentDesconto.Text.All(char.IsDigit))
            {
                MessageBox.Show("Digite apenas número", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
