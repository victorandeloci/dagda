namespace AssociacaoBidirecional
{
    partial class form_DepAgreAssoc
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
            this.btnConsumidorCorreios = new System.Windows.Forms.Button();
            this.btnConsumidorrcamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsumidorCorreios
            // 
            this.btnConsumidorCorreios.Location = new System.Drawing.Point(81, 40);
            this.btnConsumidorCorreios.Name = "btnConsumidorCorreios";
            this.btnConsumidorCorreios.Size = new System.Drawing.Size(96, 47);
            this.btnConsumidorCorreios.TabIndex = 0;
            this.btnConsumidorCorreios.Text = "Consumidor - Correios";
            this.btnConsumidorCorreios.UseVisualStyleBackColor = true;
            this.btnConsumidorCorreios.Click += new System.EventHandler(this.btnConsumidorCorreios_Click);
            // 
            // btnConsumidorrcamento
            // 
            this.btnConsumidorrcamento.Location = new System.Drawing.Point(81, 93);
            this.btnConsumidorrcamento.Name = "btnConsumidorrcamento";
            this.btnConsumidorrcamento.Size = new System.Drawing.Size(96, 47);
            this.btnConsumidorrcamento.TabIndex = 1;
            this.btnConsumidorrcamento.Text = "Consumidor - Orçamento";
            this.btnConsumidorrcamento.UseVisualStyleBackColor = true;
            this.btnConsumidorrcamento.Click += new System.EventHandler(this.btnConsumidorrcamento_Click);
            // 
            // form_DepAgreAssoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 367);
            this.Controls.Add(this.btnConsumidorrcamento);
            this.Controls.Add(this.btnConsumidorCorreios);
            this.Name = "form_DepAgreAssoc";
            this.Text = "form_DepAgreAssoc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsumidorCorreios;
        private System.Windows.Forms.Button btnConsumidorrcamento;
    }
}