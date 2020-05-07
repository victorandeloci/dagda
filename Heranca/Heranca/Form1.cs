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

                cEsp.imprimirDados();
                cEsp.imprimeCredito();

            } else {

                Conta cNorm = new Conta();

                cNorm.NumConta = numConta;
                cNorm.NomeCliente = nome;
                cNorm.depositar(saldo);

                cNorm.imprimirDados();

            }
        }
    }
}
