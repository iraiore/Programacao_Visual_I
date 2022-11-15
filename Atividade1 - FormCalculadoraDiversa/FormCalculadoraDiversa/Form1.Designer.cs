namespace FormCalculadoraDiversa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btAumentarSalario = new System.Windows.Forms.Button();
            this.btCalcularDesconto = new System.Windows.Forms.Button();
            this.btCalcularArea = new System.Windows.Forms.Button();
            this.btCalcularJuros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAumentarSalario
            // 
            this.btAumentarSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAumentarSalario.Location = new System.Drawing.Point(63, 47);
            this.btAumentarSalario.Name = "btAumentarSalario";
            this.btAumentarSalario.Size = new System.Drawing.Size(127, 44);
            this.btAumentarSalario.TabIndex = 1;
            this.btAumentarSalario.Text = "CALCULAR AUMENTO";
            this.btAumentarSalario.UseVisualStyleBackColor = true;
            this.btAumentarSalario.Click += new System.EventHandler(this.btAumentarSalario_Click);
            // 
            // btCalcularDesconto
            // 
            this.btCalcularDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularDesconto.Location = new System.Drawing.Point(63, 116);
            this.btCalcularDesconto.Name = "btCalcularDesconto";
            this.btCalcularDesconto.Size = new System.Drawing.Size(127, 44);
            this.btCalcularDesconto.TabIndex = 2;
            this.btCalcularDesconto.Text = "CALCULAR DESCONTO";
            this.btCalcularDesconto.UseVisualStyleBackColor = true;
            this.btCalcularDesconto.Click += new System.EventHandler(this.btCalcularDesconto_Click);
            // 
            // btCalcularArea
            // 
            this.btCalcularArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularArea.Location = new System.Drawing.Point(63, 186);
            this.btCalcularArea.Name = "btCalcularArea";
            this.btCalcularArea.Size = new System.Drawing.Size(127, 44);
            this.btCalcularArea.TabIndex = 3;
            this.btCalcularArea.Text = "CALCULAR ÁREA";
            this.btCalcularArea.UseVisualStyleBackColor = true;
            this.btCalcularArea.Click += new System.EventHandler(this.btCalcularArea_Click);
            // 
            // btCalcularJuros
            // 
            this.btCalcularJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularJuros.Location = new System.Drawing.Point(63, 253);
            this.btCalcularJuros.Name = "btCalcularJuros";
            this.btCalcularJuros.Size = new System.Drawing.Size(127, 44);
            this.btCalcularJuros.TabIndex = 4;
            this.btCalcularJuros.Text = "CALCULAR JUROS";
            this.btCalcularJuros.UseVisualStyleBackColor = true;
            this.btCalcularJuros.Click += new System.EventHandler(this.btCalcularJuros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(268, 450);
            this.Controls.Add(this.btCalcularJuros);
            this.Controls.Add(this.btCalcularArea);
            this.Controls.Add(this.btCalcularDesconto);
            this.Controls.Add(this.btAumentarSalario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CALCULADORA DIVERSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAumentarSalario;
        private System.Windows.Forms.Button btCalcularDesconto;
        private System.Windows.Forms.Button btCalcularArea;
        private System.Windows.Forms.Button btCalcularJuros;
    }
}

