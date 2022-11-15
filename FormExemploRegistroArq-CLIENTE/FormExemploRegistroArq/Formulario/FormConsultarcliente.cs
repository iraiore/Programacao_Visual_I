using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormExemploRegistroArq.Formulario
{
    public partial class FormConsultarcliente : Form
    {
        public FormConsultarcliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente()
        {
            int cont = 0;//contar os clientes encontrados
            StreamReader sr = new StreamReader("Cliente.csv");
            while (!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                if (registro[0] != "ID")
                {
                    if (registro[2] == txtCpf.Text)
                    {
                        dgvTabela.Rows.Add(registro[0],//ID
                                           registro[1],//NOME
                                           registro[2],//CPF
                                           registro[3],//E-MAIL
                                           registro[4] ///RENDA
                                           );
                        cont++;
                    }
                }
            }
            sr.Close();
            if (cont == 0) MessageBox.Show("Não encontrado",//mensagem
                                           "ADS 2P", //titulo
                                           MessageBoxButtons.OK, //
                                           MessageBoxIcon.Information
                                           );

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Clear();
            BuscarCliente();
        }

    }
}
