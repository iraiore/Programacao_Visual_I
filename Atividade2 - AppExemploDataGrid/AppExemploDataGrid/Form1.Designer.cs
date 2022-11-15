namespace AppExemploDataGrid
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
            this.btFormatacaoTabela = new System.Windows.Forms.Button();
            this.btExemploRegistro = new System.Windows.Forms.Button();
            this.btUsabilidade = new System.Windows.Forms.Button();
            this.btExercicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFormatacaoTabela
            // 
            this.btFormatacaoTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFormatacaoTabela.Location = new System.Drawing.Point(221, 62);
            this.btFormatacaoTabela.Name = "btFormatacaoTabela";
            this.btFormatacaoTabela.Size = new System.Drawing.Size(365, 34);
            this.btFormatacaoTabela.TabIndex = 0;
            this.btFormatacaoTabela.Text = "FORMATAÇÃO DA TABELA";
            this.btFormatacaoTabela.UseVisualStyleBackColor = true;
            this.btFormatacaoTabela.Click += new System.EventHandler(this.btFormatacaoTabela_Click);
            // 
            // btExemploRegistro
            // 
            this.btExemploRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploRegistro.Location = new System.Drawing.Point(221, 148);
            this.btExemploRegistro.Name = "btExemploRegistro";
            this.btExemploRegistro.Size = new System.Drawing.Size(365, 34);
            this.btExemploRegistro.TabIndex = 1;
            this.btExemploRegistro.Text = "EXEMPLO DE REGISTRO";
            this.btExemploRegistro.UseVisualStyleBackColor = true;
            this.btExemploRegistro.Click += new System.EventHandler(this.btExemploRegistro_Click);
            // 
            // btUsabilidade
            // 
            this.btUsabilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsabilidade.Location = new System.Drawing.Point(221, 229);
            this.btUsabilidade.Name = "btUsabilidade";
            this.btUsabilidade.Size = new System.Drawing.Size(365, 34);
            this.btUsabilidade.TabIndex = 2;
            this.btUsabilidade.Text = "REGISTRO COM USABILIDADE";
            this.btUsabilidade.UseVisualStyleBackColor = true;
            this.btUsabilidade.Click += new System.EventHandler(this.btUsabilidade_Click);
            // 
            // btExercicio
            // 
            this.btExercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExercicio.Location = new System.Drawing.Point(221, 314);
            this.btExercicio.Name = "btExercicio";
            this.btExercicio.Size = new System.Drawing.Size(365, 34);
            this.btExercicio.TabIndex = 3;
            this.btExercicio.Text = "REAJUSTE SALARIAL";
            this.btExercicio.UseVisualStyleBackColor = true;
            this.btExercicio.Click += new System.EventHandler(this.btExercicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btExercicio);
            this.Controls.Add(this.btUsabilidade);
            this.Controls.Add(this.btExemploRegistro);
            this.Controls.Add(this.btFormatacaoTabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFormatacaoTabela;
        private System.Windows.Forms.Button btExemploRegistro;
        private System.Windows.Forms.Button btUsabilidade;
        private System.Windows.Forms.Button btExercicio;
    }
}

