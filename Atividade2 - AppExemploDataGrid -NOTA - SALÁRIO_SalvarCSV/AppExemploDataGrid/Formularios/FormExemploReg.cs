using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploDataGrid.Formularios
{
    public partial class FormExemploReg : Form
    {
        public FormExemploReg()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(txtDescricao.Text,               // posição 1
                                double.Parse(txtValorUnit.Text),//posição 2
                                double.Parse(txtQuant.Text),    //posição 3
                                double.Parse(txtTotal.Text)     //posição 4
                                );

            Totalizar();
            //limpando os campos para entrada de um novo item
            txtDescricao.Clear();
            txtValorUnit.Clear();
            txtQuant.Clear();
            txtTotal.Clear();
            txtDescricao.Select();
        }

        private void txtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtValorUnit.Select();
            }
        }

        private void txtValorUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtQuant.Select();
            }
        }

        private void txtQuant_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                double ValorUnit = double.Parse(txtValorUnit.Text);
                double Quant = double.Parse(txtQuant.Text);
                double Total = ValorUnit * Quant;
                txtTotal.Text = Total.ToString();
                txtTotal.Select();
                txtTotal.ReadOnly = true;
            }
        }
        private void Totalizar()
        {
            double Total = 0;
            for (int i=0; i < dgvTabela.RowCount; i++)
            {
                Total = Convert.ToDouble(dgvTabela[3, i].Value) + Total;
            }
            txtTotalGeral.Text = Total.ToString("C2");
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linhaSelecioanda = dgvTabela.CurrentRow.Index;// pega o numero da linha selecioanda e armazena dentro da variavel
            int qtdLinhas = dgvTabela.RowCount;// soma a quantidade de linhas na tabela e coloca dentro da variavel
            if (qtdLinhas > 1)
            {
                DialogResult resp = MessageBox.Show("Deseja mesmo deletar?",//mensagem da msgbox
                                                    "ADS", //tiutlo da mensagebox
                                                    MessageBoxButtons.YesNo,//botao de confgirmação de exlusão
                                                    MessageBoxIcon.Question);//simbolo d interrogação

                if (resp == DialogResult.Yes)
                {
                    dgvTabela.Rows.RemoveAt(linhaSelecioanda);
                    Totalizar();
                }
            }

        }
    }
}
