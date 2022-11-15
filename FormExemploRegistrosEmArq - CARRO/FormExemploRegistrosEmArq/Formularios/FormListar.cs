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
    public partial class FormListar : Form
    {
    
        public FormListar()
        {
            InitializeComponent();
            CarregarTabela();
           
        }
        private void CarregarTabela()
        {
            StreamReader sr = new StreamReader("cad_veiculos.csv");
            while (!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                if (registro[0] != "ID")
                {
                    dgvTabela.Rows.Add(registro[0],//ID
                                       registro[1],//MODELO
                                       registro[2],//PLACA
                                       registro[3] //ANO
                                       );
                }
            }
            sr.Close();
        }

       
    }
}
