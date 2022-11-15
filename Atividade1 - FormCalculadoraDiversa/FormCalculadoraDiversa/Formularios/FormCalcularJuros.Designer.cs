namespace FormCalculadoraDiversa.Formularios
{
    partial class FormCalcularJuros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbMontante = new System.Windows.Forms.Label();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lbCapital = new System.Windows.Forms.Label();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lbTaxa = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lbTempo = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE O QUE DESEJA CALCULAR";
            // 
            // lbMontante
            // 
            this.lbMontante.AutoSize = true;
            this.lbMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontante.Location = new System.Drawing.Point(12, 72);
            this.lbMontante.Name = "lbMontante";
            this.lbMontante.Size = new System.Drawing.Size(100, 18);
            this.lbMontante.TabIndex = 1;
            this.lbMontante.Text = "MONTANTE";
            // 
            // cbOpcao
            // 
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "ENCONTRAR MONTANTE",
            "ENCONTRAR CAPITAL",
            "ENCONTRAR TAXA",
            "ENCONTRAR TEMPO"});
            this.cbOpcao.Location = new System.Drawing.Point(16, 31);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(317, 21);
            this.cbOpcao.TabIndex = 2;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // txtMontante
            // 
            this.txtMontante.Location = new System.Drawing.Point(12, 93);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(155, 20);
            this.txtMontante.TabIndex = 3;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(12, 153);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(155, 20);
            this.txtCapital.TabIndex = 5;
            // 
            // lbCapital
            // 
            this.lbCapital.AutoSize = true;
            this.lbCapital.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.lbCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapital.Location = new System.Drawing.Point(12, 132);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(74, 18);
            this.lbCapital.TabIndex = 4;
            this.lbCapital.Text = "CAPITAL";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(13, 211);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(155, 20);
            this.txtTaxa.TabIndex = 7;
            // 
            // lbTaxa
            // 
            this.lbTaxa.AutoSize = true;
            this.lbTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxa.Location = new System.Drawing.Point(13, 190);
            this.lbTaxa.Name = "lbTaxa";
            this.lbTaxa.Size = new System.Drawing.Size(49, 18);
            this.lbTaxa.TabIndex = 6;
            this.lbTaxa.Text = "TAXA";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(12, 271);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(155, 20);
            this.txtTempo.TabIndex = 9;
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempo.Location = new System.Drawing.Point(12, 250);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(67, 18);
            this.lbTempo.TabIndex = 8;
            this.lbTempo.Text = "TEMPO";
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(197, 109);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(115, 41);
            this.btCalcular.TabIndex = 10;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(197, 179);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(115, 41);
            this.btNovo.TabIndex = 11;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormCalcularJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.lbTaxa);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.lbCapital);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.lbMontante);
            this.Controls.Add(this.label1);
            this.Name = "FormCalcularJuros";
            this.Text = "FormCalcularJuros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMontante;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label lbCapital;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label lbTaxa;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
    }
}