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
    public partial class FormCalcularJuros : Form
    {
        public FormCalcularJuros()
        {
            InitializeComponent();
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opc = cbOpcao.SelectedIndex;
            switch (opc)

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
                    txtCapital.ReadOnly =false;
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

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double montante, capital, taxa, tempo;
            int opc = cbOpcao.SelectedIndex;
            switch (opc)
            {
                case 0:
                    capital = double.Parse(txtCapital.Text);
                    //montante = double.Parse(txtMontante.Text);
                    taxa = double.Parse(txtTaxa.Text);
                    taxa = taxa / 100;
                    tempo = double.Parse(txtTempo.Text);
                    //calculo
                    montante = capital * (1 + taxa*tempo);
                    txtMontante.Text = montante.ToString("F2");
                    break;
                case 1:
                    //capital = double.Parse(txtCapital.Text);
                    montante = double.Parse(txtMontante.Text);
                    taxa = double.Parse(txtTaxa.Text);
                    taxa = taxa / 100;
                    tempo = double.Parse(txtTempo.Text);
                    //calculo
                    capital = montante / (1 + taxa * tempo);
                    txtCapital.Text = capital.ToString("F2");
                    break;
                case 2:
                    capital = double.Parse(txtCapital.Text);
                    montante = double.Parse(txtMontante.Text);
                    //taxa = double.Parse(txtTaxa.Text);
                    //taxa = taxa / 100;
                    tempo = double.Parse(txtTempo.Text);
                    //calculo
                    taxa = (montante - capital) / (capital * tempo)*100;
                    txtTaxa.Text = taxa.ToString("F2");
                    break;
                case 3:
                    capital = double.Parse(txtCapital.Text);
                    montante = double.Parse(txtMontante.Text);
                    taxa = double.Parse(txtTaxa.Text);
                    taxa = taxa / 100;
                    //tempo = double.Parse(txtTempo.Text);
                    //calculo
                    tempo = (montante - capital) / (capital * taxa);
                    txtTempo.Text = tempo.ToString("F2");
                    break;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtCapital.Clear();
            txtMontante.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            cbOpcao.Select();
        }
    }

}
