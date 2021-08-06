using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssociacaoBidirecional
{
    public partial class form_DepAgreAssoc : Form
    {
        public form_DepAgreAssoc()
        {
            InitializeComponent();
        }

        private void btnConsumidorCorreios_Click(object sender, EventArgs e)
        {
            Consumidor cons = new Consumidor();
            cons.inserirDados(100, "Potter", "14");

            cons.imprimirDados();
        }

        private void btnConsumidorrcamento_Click(object sender, EventArgs e)
        {
            Consumidor cons = new Consumidor();
            cons.inserirDados(100, "Potter", "14");

            Orcamento orc = new Orcamento();
            orc.inserirDados(100, cons, 30000f);

            orc.imprimirDados();
        }
    }
}
