using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploDataGrid.Formularios; 

namespace AppExemploDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btFormatacaoTabela_Click(object sender, EventArgs e)
        {
            FormFormatacao form = new FormFormatacao();
            form.ShowDialog();
        }

        private void btExemploRegistro_Click(object sender, EventArgs e)
        {
            FormExemploReg form = new FormExemploReg(); 
            form.ShowDialog();
        }

        private void btUsabilidade_Click(object sender, EventArgs e)
        {
            FormRegistro form = new FormRegistro();
            form.ShowDialog();
        }

        private void btExercicio_Click(object sender, EventArgs e)
        {
            FormRegistroSalario form = new FormRegistroSalario();
            form.ShowDialog();
        }
    }
}
