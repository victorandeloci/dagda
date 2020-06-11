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
            this.btnMontadoraVeidulo = new System.Windows.Forms.Button();
            this.btnProfRegistro = new System.Windows.Forms.Button();
            this.btnRegistroCivil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstadoGovernador
            // 
            this.btnEstadoGovernador.Location = new System.Drawing.Point(76, 56);
            this.btnEstadoGovernador.Name = "btnEstadoGovernador";
            this.btnEstadoGovernador.Size = new System.Drawing.Size(102, 48);
            this.btnEstadoGovernador.TabIndex = 0;
            this.btnEstadoGovernador.Text = "Estado - Governador";
            this.btnEstadoGovernador.UseVisualStyleBackColor = true;
            this.btnEstadoGovernador.Click += new System.EventHandler(this.btnEstadoGovernador_Click);
            // 
            // btnMontadoraVeidulo
            // 
            this.btnMontadoraVeidulo.Location = new System.Drawing.Point(76, 110);
            this.btnMontadoraVeidulo.Name = "btnMontadoraVeidulo";
            this.btnMontadoraVeidulo.Size = new System.Drawing.Size(102, 48);
            this.btnMontadoraVeidulo.TabIndex = 1;
            this.btnMontadoraVeidulo.Text = "Montadora - Veículo";
            this.btnMontadoraVeidulo.UseVisualStyleBackColor = true;
            this.btnMontadoraVeidulo.Click += new System.EventHandler(this.btnMontadoraVeidulo_Click);
            // 
            // btnProfRegistro
            // 
            this.btnProfRegistro.Location = new System.Drawing.Point(76, 164);
            this.btnProfRegistro.Name = "btnProfRegistro";
            this.btnProfRegistro.Size = new System.Drawing.Size(102, 48);
            this.btnProfRegistro.TabIndex = 2;
            this.btnProfRegistro.Text = "Professor";
            this.btnProfRegistro.UseVisualStyleBackColor = true;
            this.btnProfRegistro.Click += new System.EventHandler(this.btnProfRegistro_Click);
            // 
            // btnRegistroCivil
            // 
            this.btnRegistroCivil.Location = new System.Drawing.Point(76, 218);
            this.btnRegistroCivil.Name = "btnRegistroCivil";
            this.btnRegistroCivil.Size = new System.Drawing.Size(102, 48);
            this.btnRegistroCivil.TabIndex = 3;
            this.btnRegistroCivil.Text = "Registro Civil";
            this.btnRegistroCivil.UseVisualStyleBackColor = true;
            this.btnRegistroCivil.Click += new System.EventHandler(this.btnRegistroCivil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 335);
            this.Controls.Add(this.btnRegistroCivil);
            this.Controls.Add(this.btnProfRegistro);
            this.Controls.Add(this.btnMontadoraVeidulo);
            this.Controls.Add(this.btnEstadoGovernador);
            this.Name = "Form1";
            this.Text = "Associação Bidirecional";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstadoGovernador;
        private System.Windows.Forms.Button btnMontadoraVeidulo;
        private System.Windows.Forms.Button btnProfRegistro;
        private System.Windows.Forms.Button btnRegistroCivil;
    }
}

