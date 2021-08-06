namespace Abstracao
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
            this.btnPessoaMetarlugicoRepresentante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPessoaMetarlugicoRepresentante
            // 
            this.btnPessoaMetarlugicoRepresentante.Location = new System.Drawing.Point(37, 30);
            this.btnPessoaMetarlugicoRepresentante.Name = "btnPessoaMetarlugicoRepresentante";
            this.btnPessoaMetarlugicoRepresentante.Size = new System.Drawing.Size(173, 83);
            this.btnPessoaMetarlugicoRepresentante.TabIndex = 0;
            this.btnPessoaMetarlugicoRepresentante.Text = "Pessoa - Metalúrgico e Representante";
            this.btnPessoaMetarlugicoRepresentante.UseVisualStyleBackColor = true;
            this.btnPessoaMetarlugicoRepresentante.Click += new System.EventHandler(this.btnPessoaMetarlugicoRepresentante_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 385);
            this.Controls.Add(this.btnPessoaMetarlugicoRepresentante);
            this.Name = "Form1";
            this.Text = "Abstracao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPessoaMetarlugicoRepresentante;
    }
}

