using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstracao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPessoaMetarlugicoRepresentante_Click(object sender, EventArgs e)
        {
            Metalurgico met = new Metalurgico();
            met.Nome = "Anão";
            met.Salario = 100f;

            Representante rep = new Representante();
            rep.Nome = "Sei lá";
            rep.Salario = 10f;
            rep.Comissao = 20f;

            met.imprimirDados();
            rep.imprimirDados();
        }
    }
}
