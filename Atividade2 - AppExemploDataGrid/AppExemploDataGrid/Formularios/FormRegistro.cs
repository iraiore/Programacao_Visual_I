using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploDataGrid.Formularios
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            //inativando todos os campos e botões exceto o botao ADD++
            //campos
            txtNome.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;
            txtMedia.Enabled = false;
            txtMediaGeral.ReadOnly = true;
            //botoes
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btDeletar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //liberando os campos para preenchimento
            txtNome.Enabled = true;
            txtNota1.Enabled = true;
            txtNota2.Enabled = true;
            txtMedia.ReadOnly = true;
            txtMedia.BackColor = Color.White;
            txtMediaGeral.ReadOnly = true;
            txtNome.Select();
            //habilitando os botoes e desabilitando o ADD
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            btDeletar.Enabled = true;
            btSalvar.Enabled = true;
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNota1.Select();
            }
        }

        private void txtNota1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNota2.Select();
            }
        }

        private void txtNota2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                double Nota1 = double.Parse(txtNota1.Text);
                double Nota2 = double.Parse(txtNota2.Text);
                double media = (Nota1 + Nota2) / 2;
                txtMedia.Text = media.ToString();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(txtNome.Text,
                                Convert.ToDouble(txtNota1.Text),
                                Convert.ToDouble(txtNota2.Text),
                                Convert.ToDouble(txtMedia.Text));
            
            //limpando os campos para entrada de novos dados
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtMedia.Clear();
            txtNome.Select();
            btAdd.Enabled = false;
            MedGeral();
        }
        private void MedGeral()
        {
            double soma = 0;
            for (int i=0; i<dgvTabela.RowCount; i++)
            {
                soma = Convert.ToDouble(dgvTabela[3, i].Value) + soma;
            }
            double media = soma /(dgvTabela.RowCount-1);
        txtMediaGeral.Text = media.ToString();
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
                    MedGeral();
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Clear();
            txtNome.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;
            txtMedia.Enabled = false;
            txtMediaGeral.ReadOnly = true;
            //botoes
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btDeletar.Enabled = false;
            btSalvar.Enabled = false;
            txtMediaGeral.Clear();
        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
