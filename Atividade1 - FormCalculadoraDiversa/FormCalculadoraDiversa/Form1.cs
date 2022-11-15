using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCalculadoraDiversa.Formularios;

namespace FormCalculadoraDiversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAumentarSalario_Click(object sender, EventArgs e)
        {
            FormAumentarSalario form = new FormAumentarSalario();
            form.ShowDialog();
        }

        private void btCalcularDesconto_Click(object sender, EventArgs e)
        {
            FormCalcularDesconto form = new FormCalcularDesconto();
            form.ShowDialog();
        }

        private void btCalcularArea_Click(object sender, EventArgs e)
        {
            FormCalcularFigura form = new FormCalcularFigura();
            form.ShowDialog();
        }

        private void btCalcularJuros_Click(object sender, EventArgs e)
        {
            FormCalcularJuros form = new FormCalcularJuros();
            form.ShowDialog();
        }
    }
}
