namespace AssociacaoBidirecional
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
            this.btnEstadoGovernador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstadoGovernador
            // 
            this.btnEstadoGovernador.Location = new System.Drawing.Point(80, 43);
            this.btnEstadoGovernador.Name = "btnEstadoGovernador";
            this.btnEstadoGovernador.Size = new System.Drawing.Size(102, 48);
            this.btnEstadoGovernador.TabIndex = 0;
            this.btnEstadoGovernador.Text = "Estado - Governador";
            this.btnEstadoGovernador.UseVisualStyleBackColor = true;
            this.btnEstadoGovernador.Click += new System.EventHandler(this.btnEstadoGovernador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 411);
            this.Controls.Add(this.btnEstadoGovernador);
            this.Name = "Form1";
            this.Text = "Associação Bidirecional";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstadoGovernador;
    }
}

