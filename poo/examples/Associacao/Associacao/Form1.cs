using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Associacao
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Computador comp = new Computador();
            comp.codigo = 1;
            comp.descricao = "Lenovo sei lá o que...";

            Tablet tablet = new Tablet();
            tablet.codigo = 10;
            tablet.descricao = "Sansung porcaria";

            Funcionario func = new Funcionario();
            func.codigo = 100;
            func.nome = "Gandalf";
            func.compt = comp;
            func.tablet = tablet;

            func.imprimirDados();
        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {
            Jogador jog = new Jogador();
            jog.nome = "Pelé";
            jog.idade = 99;

            Posicao pos = new Posicao();
            pos.nome = "Atacante";
            pos.numCamisa = 10;
            pos.jogador = jog;

            pos.imprimirDados();
        }

        private void btnArtigo_Click(object sender, EventArgs e)
        {
            Autor tolkien = new Autor();
            tolkien.nome = "Tolkien";
            tolkien.codigo = 1;

            Autor king = new Autor();
            king.nome = "S. King";
            king.codigo = 2;

            Autor martin = new Autor();
            martin.nome = "Martin";
            martin.codigo = 3;

            Artigo artigo = new Artigo();
            artigo.titulo = "Ficções interessantes";
            artigo.ano = 2020;

            artigo.Autores[0] = tolkien;
            artigo.Autores[1] = king;
            artigo.Autores[2] = martin;

            artigo.imprimirDados();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.codigo = 100;
            vendedor.nome = "Aragorn";

            Cliente cliente = new Cliente();
            cliente.nome = "C3PO";
            cliente.cidade = "Vila dos Wookies (?)";

            vendedor.Clientes.Add(cliente);
            vendedor.Clientes.Add(cliente);
            vendedor.Clientes.Add(cliente);

            vendedor.imprimirDados();
        }

        private void btnAeronaveTrecho_Click(object sender, EventArgs e)
        {
            TrechoVoo trecho = new TrechoVoo();
            trecho.origem = "Terra Média";
            trecho.destino = "Vulcan";

            Aeronave aero = new Aeronave();
            aero.modelo = "C3PO";
            aero.codigo = 100;

            aero.Trechos.Add(trecho);

            aero.imprimirDados();
        }

        private void btnReuniaoFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario gandalf = new Funcionario();
            gandalf.codigo = 100;
            gandalf.nome = "Gandalf";

            Funcionario madeline = new Funcionario();
            madeline.codigo = 200;
            madeline.nome = "Madeline";

            Reuniao reun = new Reuniao();
            reun.titulo = "A Sociedade da Montanha";
            reun.horario = new DateTime();

            reun.Participantes.Add(gandalf);
            reun.Participantes.Add(madeline);

            reun.imprimirDados();
        }
    }
}
