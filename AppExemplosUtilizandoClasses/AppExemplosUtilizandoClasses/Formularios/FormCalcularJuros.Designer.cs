namespace AppExemplosUtilizandoClasses.Formularios
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
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lbTempo = new System.Windows.Forms.Label();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lbTaxa = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lbCapital = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.lbMontante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(230, 197);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(115, 41);
            this.btNovo.TabIndex = 23;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(230, 127);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(115, 41);
            this.btCalcular.TabIndex = 22;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(45, 289);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(155, 20);
            this.txtTempo.TabIndex = 21;
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempo.Location = new System.Drawing.Point(45, 268);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(67, 18);
            this.lbTempo.TabIndex = 20;
            this.lbTempo.Text = "TEMPO";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(46, 229);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(155, 20);
            this.txtTaxa.TabIndex = 19;
            // 
            // lbTaxa
            // 
            this.lbTaxa.AutoSize = true;
            this.lbTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxa.Location = new System.Drawing.Point(46, 208);
            this.lbTaxa.Name = "lbTaxa";
            this.lbTaxa.Size = new System.Drawing.Size(49, 18);
            this.lbTaxa.TabIndex = 18;
            this.lbTaxa.Text = "TAXA";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(45, 171);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(155, 20);
            this.txtCapital.TabIndex = 17;
            // 
            // lbCapital
            // 
            this.lbCapital.AutoSize = true;
            this.lbCapital.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.lbCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapital.Location = new System.Drawing.Point(45, 150);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(74, 18);
            this.lbCapital.TabIndex = 16;
            this.lbCapital.Text = "CAPITAL";
            // 
            // txtMontante
            // 
            this.txtMontante.Location = new System.Drawing.Point(45, 111);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(155, 20);
            this.txtMontante.TabIndex = 15;
            // 
            // cbOpcao
            // 
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "MONTANTE",
            "CAPITAL",
            "TAXA",
            "TEMPO"});
            this.cbOpcao.Location = new System.Drawing.Point(49, 49);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(317, 21);
            this.cbOpcao.TabIndex = 14;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // lbMontante
            // 
            this.lbMontante.AutoSize = true;
            this.lbMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontante.Location = new System.Drawing.Point(45, 90);
            this.lbMontante.Name = "lbMontante";
            this.lbMontante.Size = new System.Drawing.Size(100, 18);
            this.lbMontante.TabIndex = 13;
            this.lbMontante.Text = "MONTANTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "SELECIONE O QUE DESEJA CALCULAR";
            // 
            // FormCalcularJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 347);
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

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label lbTaxa;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label lbCapital;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.Label lbMontante;
        private System.Windows.Forms.Label label1;
    }
}