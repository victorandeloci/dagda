namespace AssociacaoTernaria
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
            this.btnEstMatDisc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstMatDisc
            // 
            this.btnEstMatDisc.Location = new System.Drawing.Point(62, 36);
            this.btnEstMatDisc.Name = "btnEstMatDisc";
            this.btnEstMatDisc.Size = new System.Drawing.Size(208, 63);
            this.btnEstMatDisc.TabIndex = 0;
            this.btnEstMatDisc.Text = "Estudante - Matrícula - Disciplina";
            this.btnEstMatDisc.UseVisualStyleBackColor = true;
            this.btnEstMatDisc.Click += new System.EventHandler(this.btnEstMatDisc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 155);
            this.Controls.Add(this.btnEstMatDisc);
            this.Name = "Form1";
            this.Text = "Ternária ou N-ária";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstMatDisc;
    }
}

