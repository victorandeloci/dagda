using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            int numConta = Convert.ToInt32(txtNumConta.Text);
            float saldo = (float) Convert.ToDecimal(txtSaldo.Text);

            float credito = 0f;

            if(txtCredito.Text != "")
                credito = (float) Convert.ToDecimal(txtCredito.Text);

            if (credito != 0f){

                ContaEspecial cEsp = new ContaEspecial();

                cEsp.NumConta = numConta;
                cEsp.NomeCliente = nome;
                cEsp.depositar(saldo);

                cEsp.Credito = credito;

                cEsp.Sacar(10f);

                cEsp.ImprimirDados();

            } else {

                Conta cNorm = new Conta();

                cNorm.NumConta = numConta;
                cNorm.NomeCliente = nome;
                cNorm.depositar(saldo);

                cNorm.Sacar(10f);

                cNorm.ImprimirDados();

            }
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            Colaborador col = new Colaborador("João", "123456789", 100f);
            col.CalcularPLR();
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            Gerente ger = new Gerente("Maria", "987654321", 150f, "RP");
            ger.CalcularPLR();
        }
    }
}
