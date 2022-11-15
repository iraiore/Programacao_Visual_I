using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploDataGrid.Formularios
{
    public partial class FormRegistroSalario : Form
    {
        private int id;
        public FormRegistroSalario()
        {
            InitializeComponent();
            BuscarUltimoId();
            //inativando todos os campos e botões exceto o botao ADD
            //campos
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalario.Enabled = false;
            txtSalarioAtual.Enabled = false;
            //botões
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btDeletar.Enabled = false;
            btSalvar.Enabled = false;
        }
        private void bt_FinalizarRegistro_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("RegistroSalario.csv", true);
            for (int i = 0; i < dgvTabela.Rows.Count-1; i++)
            {
                id++;
                string registro = id + ";" + dgvTabela[0, i].Value + ";" + dgvTabela[1, i].Value + ";" + dgvTabela[2, i].Value + ";" + dgvTabela[3, i].Value + ";" + dgvTabela[4, i].Value;
                sw.WriteLine(registro);          
            }
            MessageBox.Show("SALVO COM SUCESSO!", "ADS 2P", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Close();
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpf.Select();
            }
        }

        private void txtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSalario.Select();
            }

        }

        private void txtSalario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReajuste.Select();
            }

        }

        private void txtReajuste_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double salario = Convert.ToDouble(txtSalario.Text);
                double percent = Convert.ToDouble(txtReajuste.Text);
                double salarioReajsutado = salario * (1 + percent / 100);
                txtSalarioAtual.Text = salarioReajsutado.ToString();
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //ativando todos os campos e botões exceto o botao ADD
            //campos
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtReajuste.Enabled = true;
            txtSalario.Enabled = true;
            txtSalarioAtual.Enabled = true;
            //botões
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            btDeletar.Enabled = true;
            btSalvar.Enabled = true;
            txtNome.Select();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(txtNome.Text,
                               txtCpf.Text,
                               Convert.ToDouble(txtSalario.Text),
                               Convert.ToDouble(txtReajuste.Text),
                               Convert.ToDouble(txtSalarioAtual.Text));
            //limpando os campos para entrada de novos dados
            txtNome.Clear();
            txtCpf.Clear();
            txtSalario.Clear();
            txtReajuste.Clear();
            txtSalarioAtual.Clear();
            btAdd.Enabled = false;
            txtNome.Select();
            MedSalarial();
        }
        private void MedSalarial()
        {
            double soma = 0;
            for (int i = 0; i < dgvTabela.RowCount; i++)
            {
                soma = Convert.ToDouble(dgvTabela[4, i].Value) + soma;
            }
            double media = soma / (dgvTabela.RowCount - 1);
            txtMediaGeral.Text = media.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Clear();
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtSalario.Enabled = false;
            txtReajuste.Enabled = false;
            txtMediaGeral.ReadOnly = true;
            //botoes
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btDeletar.Enabled = false;
            btSalvar.Enabled = false;
            txtMediaGeral.Clear();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linhaSelecioanda = dgvTabela.CurrentRow.Index;// pega o numero da linha selecioanda e armazena dentro da variavel
            int qtdLinhas = dgvTabela.RowCount;// soma a quantidade de linhas na tabela e coloca dentro da variavel
            if (qtdLinhas > 1)
            {
                DialogResult resp = MessageBox.Show("Deseja mesmo deletar?",//mensagem da msgbox
                                                    "ADS", //tiutlo da mensagebox
                                                    MessageBoxButtons.YesNo,//botao de confirmação de exlusão
                                                    MessageBoxIcon.Question);//simbolo d interrogação

                if (resp == DialogResult.Yes)
                {
                    dgvTabela.Rows.RemoveAt(linhaSelecioanda);
                    MedSalarial();
                }
            }
        }
        private void BuscarUltimoId()
        {
            StreamReader sr = new StreamReader("RegistroSalario.csv");
            while (!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                if (registro[0] != "ID") id = Convert.ToInt32(registro[0]);
            }
            sr.Close();
        }
    }
}
