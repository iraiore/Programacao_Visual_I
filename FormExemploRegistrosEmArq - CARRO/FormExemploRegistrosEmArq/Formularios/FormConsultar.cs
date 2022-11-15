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

namespace FormExemploRegistrosEmArq.Formularios
{
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }

       private void BuscarVeiculo()
        {
            int cont = 0;//contar os clientes encontrados
            StreamReader sr = new StreamReader("cad_veiculos.csv");
            while (!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                if(registro[0] != "ID")
                {
                    if(registro[1] == txtModelo.Text)
                    {
                        dgvTabela.Rows.Add(registro[0],//ID
                                           registro[1],//MODELO
                                           registro[2],//PLACA
                                           registro[3] //ANO
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
            BuscarVeiculo();
        }
    }
}
