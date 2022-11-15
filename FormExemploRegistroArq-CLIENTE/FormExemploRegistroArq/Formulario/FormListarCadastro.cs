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
    public partial class FormListarCadastro : Form
    {
        public FormListarCadastro()
        {
            InitializeComponent();
            CarregarTabela(); 
           
        }

        private void CarregarTabela()
        {
            StreamReader sr = new StreamReader("Cliente.csv");
            while (!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                if (registro[0] != "ID")
                {
                    dgvTabela.Rows.Add(registro[0],//ID
                                       registro[1],//NOME
                                       registro[2],//CPF
                                       registro[3],//E-MAIL
                                       registro[4] ///RENDA
                                       );
                }
            }
            sr.Close();

        }

        private void FormListarCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
