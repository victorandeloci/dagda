namespace Heranca
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
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnColaborador = new System.Windows.Forms.Button();
            this.btnGerente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Location = new System.Drawing.Point(87, 163);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(75, 23);
            this.btnCriarConta.TabIndex = 0;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNumConta
            // 
            this.txtNumConta.Location = new System.Drawing.Point(76, 60);
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(100, 20);
            this.txtNumConta.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(76, 86);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(76, 112);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 20);
            this.txtCredito.TabIndex = 4;
            // 
            // btnColaborador
            // 
            this.btnColaborador.Location = new System.Drawing.Point(303, 45);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Size = new System.Drawing.Size(117, 49);
            this.btnColaborador.TabIndex = 5;
            this.btnColaborador.Text = "Colaborador";
            this.btnColaborador.UseVisualStyleBackColor = true;
            this.btnColaborador.Click += new System.EventHandler(this.btnColaborador_Click);
            // 
            // btnGerente
            // 
            this.btnGerente.Location = new System.Drawing.Point(303, 100);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(117, 47);
            this.btnGerente.TabIndex = 6;
            this.btnGerente.Text = "Gerente";
            this.btnGerente.UseVisualStyleBackColor = true;
            this.btnGerente.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 215);
            this.Controls.Add(this.btnGerente);
            this.Controls.Add(this.btnColaborador);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCriarConta);
            this.Name = "Form1";
            this.Text = "Heranca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Button btnColaborador;
        private System.Windows.Forms.Button btnGerente;
    }
}

