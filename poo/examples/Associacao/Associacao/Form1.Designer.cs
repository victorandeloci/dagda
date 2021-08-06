namespace Associacao
{
    partial class Formulario
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
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.btnArtigo = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnAeronaveTrecho = new System.Windows.Forms.Button();
            this.btnReuniaoFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(86, 53);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(117, 46);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "Funcionário - Computador";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnPosicao
            // 
            this.btnPosicao.Location = new System.Drawing.Point(86, 157);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(117, 46);
            this.btnPosicao.TabIndex = 1;
            this.btnPosicao.Text = "Jogador - Posição";
            this.btnPosicao.UseVisualStyleBackColor = true;
            this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
            // 
            // btnArtigo
            // 
            this.btnArtigo.Location = new System.Drawing.Point(86, 209);
            this.btnArtigo.Name = "btnArtigo";
            this.btnArtigo.Size = new System.Drawing.Size(117, 46);
            this.btnArtigo.TabIndex = 2;
            this.btnArtigo.Text = "Artigo - Autor";
            this.btnArtigo.UseVisualStyleBackColor = true;
            this.btnArtigo.Click += new System.EventHandler(this.btnArtigo_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(86, 261);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(117, 46);
            this.btnVendedor.TabIndex = 3;
            this.btnVendedor.Text = "Vendedor - Cliente";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAeronaveTrecho
            // 
            this.btnAeronaveTrecho.Location = new System.Drawing.Point(86, 313);
            this.btnAeronaveTrecho.Name = "btnAeronaveTrecho";
            this.btnAeronaveTrecho.Size = new System.Drawing.Size(117, 46);
            this.btnAeronaveTrecho.TabIndex = 4;
            this.btnAeronaveTrecho.Text = "Aeronave - Trecho";
            this.btnAeronaveTrecho.UseVisualStyleBackColor = true;
            this.btnAeronaveTrecho.Click += new System.EventHandler(this.btnAeronaveTrecho_Click);
            // 
            // btnReuniaoFuncionario
            // 
            this.btnReuniaoFuncionario.Location = new System.Drawing.Point(86, 105);
            this.btnReuniaoFuncionario.Name = "btnReuniaoFuncionario";
            this.btnReuniaoFuncionario.Size = new System.Drawing.Size(117, 46);
            this.btnReuniaoFuncionario.TabIndex = 5;
            this.btnReuniaoFuncionario.Text = "Reuniao - Funcionário";
            this.btnReuniaoFuncionario.UseVisualStyleBackColor = true;
            this.btnReuniaoFuncionario.Click += new System.EventHandler(this.btnReuniaoFuncionario_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 486);
            this.Controls.Add(this.btnReuniaoFuncionario);
            this.Controls.Add(this.btnAeronaveTrecho);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.btnArtigo);
            this.Controls.Add(this.btnPosicao);
            this.Controls.Add(this.btnFuncionario);
            this.Name = "Formulario";
            this.Text = "Associacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnArtigo;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnAeronaveTrecho;
        private System.Windows.Forms.Button btnReuniaoFuncionario;
    }
}

