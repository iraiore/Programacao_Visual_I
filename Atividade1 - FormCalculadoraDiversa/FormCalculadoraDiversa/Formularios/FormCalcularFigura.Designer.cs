namespace FormCalculadoraDiversa.Formularios
{
    partial class FormCalcularFigura
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
            this.lbValor1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lbValor2 = new System.Windows.Forms.Label();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.lbValor3 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE UMA FIGURA";
            // 
            // lbValor1
            // 
            this.lbValor1.AutoSize = true;
            this.lbValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor1.Location = new System.Drawing.Point(13, 85);
            this.lbValor1.Name = "lbValor1";
            this.lbValor1.Size = new System.Drawing.Size(73, 16);
            this.lbValor1.TabIndex = 1;
            this.lbValor1.Text = "VALOR 1:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(16, 104);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(213, 20);
            this.txtValor1.TabIndex = 2;
            this.txtValor1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValor1_KeyUp);
            // 
            // cbOpcao
            // 
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "LOSANGO",
            "RETÂNGULO",
            "TRAPÉZIO",
            "TRIÂNGULO RETÂNGULO",
            "TRIÂNGULO EQUILÁETERO"});
            this.cbOpcao.Location = new System.Drawing.Point(16, 42);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(213, 21);
            this.cbOpcao.TabIndex = 3;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(16, 161);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(213, 20);
            this.txtValor2.TabIndex = 5;
            this.txtValor2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValor2_KeyUp);
            // 
            // lbValor2
            // 
            this.lbValor2.AutoSize = true;
            this.lbValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor2.Location = new System.Drawing.Point(13, 142);
            this.lbValor2.Name = "lbValor2";
            this.lbValor2.Size = new System.Drawing.Size(73, 16);
            this.lbValor2.TabIndex = 4;
            this.lbValor2.Text = "VALOR 2:";
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(16, 225);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(213, 20);
            this.txtValor3.TabIndex = 7;
            this.txtValor3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValor3_KeyUp);
            // 
            // lbValor3
            // 
            this.lbValor3.AutoSize = true;
            this.lbValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor3.Location = new System.Drawing.Point(13, 206);
            this.lbValor3.Name = "lbValor3";
            this.lbValor3.Size = new System.Drawing.Size(73, 16);
            this.lbValor3.TabIndex = 6;
            this.lbValor3.Text = "VALOR 3:";
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(26, 272);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(86, 38);
            this.btCalcular.TabIndex = 8;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(153, 272);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(86, 38);
            this.btNovo.TabIndex = 9;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(26, 353);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(213, 20);
            this.txtResultado.TabIndex = 11;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(23, 334);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(103, 16);
            this.lbResultado.TabIndex = 10;
            this.lbResultado.Text = "RESULTADO:";
            // 
            // FormCalcularFigura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.lbValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lbValor2);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lbValor1);
            this.Controls.Add(this.label1);
            this.Name = "FormCalcularFigura";
            this.Text = "CALCULAR ÁREA DE FIGURAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbValor1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lbValor2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Label lbValor3;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lbResultado;
    }
}