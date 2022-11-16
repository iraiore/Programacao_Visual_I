namespace AppExemplosUtilizandoClasses.Formularios
{
    partial class FormCalcurarReajuste
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalarioReajustado = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcularReajuste = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPercentualReajuste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalarioAtual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "SALÁRIO REAJUSTADO:";
            // 
            // txtSalarioReajustado
            // 
            this.txtSalarioReajustado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioReajustado.Location = new System.Drawing.Point(41, 277);
            this.txtSalarioReajustado.Name = "txtSalarioReajustado";
            this.txtSalarioReajustado.Size = new System.Drawing.Size(233, 26);
            this.txtSalarioReajustado.TabIndex = 22;
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(160, 200);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(114, 34);
            this.btNovo.TabIndex = 21;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcularReajuste
            // 
            this.btCalcularReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularReajuste.Location = new System.Drawing.Point(41, 200);
            this.btCalcularReajuste.Name = "btCalcularReajuste";
            this.btCalcularReajuste.Size = new System.Drawing.Size(114, 34);
            this.btCalcularReajuste.TabIndex = 20;
            this.btCalcularReajuste.Text = "CALCULAR";
            this.btCalcularReajuste.UseVisualStyleBackColor = true;
            this.btCalcularReajuste.Click += new System.EventHandler(this.btCalcularReajuste_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "PERC(%) REAJUSTE:";
            // 
            // txtPercentualReajuste
            // 
            this.txtPercentualReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualReajuste.Location = new System.Drawing.Point(41, 130);
            this.txtPercentualReajuste.Name = "txtPercentualReajuste";
            this.txtPercentualReajuste.Size = new System.Drawing.Size(233, 26);
            this.txtPercentualReajuste.TabIndex = 18;
            this.txtPercentualReajuste.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPercentualReajsute_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "SALÁRIO ATUAL:";
            // 
            // txtSalarioAtual
            // 
            this.txtSalarioAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioAtual.Location = new System.Drawing.Point(41, 49);
            this.txtSalarioAtual.Name = "txtSalarioAtual";
            this.txtSalarioAtual.Size = new System.Drawing.Size(233, 26);
            this.txtSalarioAtual.TabIndex = 16;
            this.txtSalarioAtual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalarioAtual_KeyUp);
            // 
            // FormCalcurarReajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalarioReajustado);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcularReajuste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPercentualReajuste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalarioAtual);
            this.Name = "FormCalcurarReajuste";
            this.Text = "FormCalcurarReajuste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalarioReajustado;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcularReajuste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPercentualReajuste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioAtual;
    }
}