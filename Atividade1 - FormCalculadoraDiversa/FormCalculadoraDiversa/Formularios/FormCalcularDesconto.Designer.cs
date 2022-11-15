namespace FormCalculadoraDiversa.Formularios
{
    partial class FormCalcularDesconto
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
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPercentDesconto = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompraDesconto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(43, 73);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(233, 26);
            this.txtValorCompra.TabIndex = 0;
            this.txtValorCompra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorCompra_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "VALOR DA COMPRA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "PERC(%) DESCONTO:";
            // 
            // txtPercentDesconto
            // 
            this.txtPercentDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentDesconto.Location = new System.Drawing.Point(43, 154);
            this.txtPercentDesconto.Name = "txtPercentDesconto";
            this.txtPercentDesconto.Size = new System.Drawing.Size(233, 26);
            this.txtPercentDesconto.TabIndex = 2;
            this.txtPercentDesconto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPercentDesconto_KeyUp);
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(43, 224);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(114, 34);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(172, 224);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(114, 34);
            this.btNovo.TabIndex = 5;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "VALOR COM  DESCONTO:";
            // 
            // txtCompraDesconto
            // 
            this.txtCompraDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompraDesconto.Location = new System.Drawing.Point(43, 301);
            this.txtCompraDesconto.Name = "txtCompraDesconto";
            this.txtCompraDesconto.Size = new System.Drawing.Size(233, 26);
            this.txtCompraDesconto.TabIndex = 6;
            // 
            // FormCalcularDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompraDesconto);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPercentDesconto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorCompra);
            this.Name = "FormCalcularDesconto";
            this.Text = "CALCULAR DESCONTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPercentDesconto;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompraDesconto;
    }
}