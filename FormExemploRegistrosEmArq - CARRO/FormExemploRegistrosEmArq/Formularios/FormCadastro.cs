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
    public partial class FormCadastro : Form
    {
        private int id;
        public FormCadastro()
        {
            InitializeComponent();
            BuscarUltimoId();
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            id++;
            StreamWriter sw = new StreamWriter("cad_veiculos.csv", true);
            string registro = id + ";" + txtModelo.Text + ";" + txtPlaca.Text + ";" + txtAno.Text;
            sw.WriteLine(registro);
            MessageBox.Show("SALVO COM SUCESSO!",
                            "ADS 2P",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
            sw.Close();
            txtAno.Clear(); txtModelo.Clear(); txtPlaca.Clear();    

        }

        private void BuscarUltimoId()
        {
            StreamReader sr = new StreamReader("cad_veiculos.csv");
            while (!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                if (registro[0] != "ID") id = Convert.ToInt32(registro[0]);
            }
            sr.Close();
        }

    }
}
