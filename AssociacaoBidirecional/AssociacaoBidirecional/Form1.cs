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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstadoGovernador_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();
            estado.nome = "São Paulo";
            estado.uf = "SP";

            Governador gov = new Governador();
            gov.nome = "Gandalf";
            gov.cpf = "123456789";

            estado.governador = gov;
            gov.estado = estado;

            estado.imprimirDados();
        }
    }
}
