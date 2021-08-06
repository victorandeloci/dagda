using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_p2
{
    public partial class formPOO : Form
    {
        public formPOO()
        {
            InitializeComponent();
        }

        private void btnFuncionarioFerramenta_Click(object sender, EventArgs e)
        {
            Ferramenta ferr = new Ferramenta();
            ferr.CodEquipamento = 111;
            ferr.Descricao = "Descrição da Ferramenta";

            Funcionario func = new Funcionario();
            func.Nome = "Gandalf";
            func.CodFunc = 1;
            func.Ferramenta = ferr;

            func.imprimirDados();
        }

        private void btnYoutuberVideo_Click(object sender, EventArgs e)
        {
            Video vid1 = new Video();
            vid1.Titulo = "Primeiro Vídeo";
            vid1.Duracao = 15.50;

            Video vid2 = new Video();
            vid2.Titulo = "Segundo Vídeo";
            vid2.Duracao = 30.50;

            Youtuber yout = new Youtuber();
            yout.Nome = "Felipe Neto";
            yout.Canal = "Aquele lá...";
            yout.Videos.Add(vid1);
            yout.Videos.Add(vid2);

            yout.imprimirDados();
        }

        private void btnPrefeitoCidade_Click(object sender, EventArgs e)
        {
            Prefeito pref = new Prefeito();
            pref.Nome = "Robertão Sangue Bão";
            pref.Legenda = "Legenda (?)";

            Cidade cid = new Cidade();
            cid.Nome = "São Lourenço";
            cid.UF = "MG";
            cid.Prefeito = pref;

            pref.Cidade = cid;

            pref.imprimirDados();
        }

        private void btnFabricanteInstrumentos_Click(object sender, EventArgs e)
        {
            Fabricante fab = new Fabricante();
            fab.Nome = "Tagima";
            fab.Cnpj = "000.000.000";

            InstrumentoMusical violao = new InstrumentoMusical();
            violao.Nome = "Violão - Café Series";
            violao.Tipo = "Corda";

            InstrumentoMusical guit = new InstrumentoMusical();
            guit.Nome = "Tagima Rocker";
            guit.Tipo = "Corda";

            fab.Instrumentos.Add(violao);
            fab.Instrumentos.Add(guit);

            fab.imprimirDados();
        }

        private void btnClienteRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante rest = new Restaurante();
            rest.Nome = "Três Vassouras";
            rest.Endereco = "Hogsmeade";

            Cliente harry = new Cliente();
            harry.Nome = "Harry J. Potter";
            harry.Cpf = "000000000";

            Cliente voldemort = new Cliente();
            voldemort.Nome = "Tom R.";
            voldemort.Cpf = "000000000";

            rest.Clientes.Add(harry);
            rest.Clientes.Add(voldemort);

            rest.imprimirDados();
        }

        private void btnJogoFutClube_Click(object sender, EventArgs e)
        {
            Clube clube = new Clube();
            clube.Nome = "Verdão";
            clube.Mascote = "Bacon";

            Jogo jogo1 = new Jogo();
            jogo1.Campeonato = "Paulista";
            jogo1.Data = DateTime.Now;

            Futebolista valdivia = new Futebolista();
            valdivia.Nome = "Valdivia";
            valdivia.Posicao = "Atacante (?)";
            valdivia.Clube = clube;
            valdivia.Jogos.Add(jogo1);

            valdivia.imprimirDados();
        }

        private void btnEditoraRevistaArtigo_Click(object sender, EventArgs e)
        {
            Artigo art = new Artigo();
            art.Nome = "A Terra não é plana!!!";
            art.Descricao = "chega de ignorância";

            Revista rev = new Revista();
            rev.Nome = "Earth Things";
            rev.Edicao = 4;
            rev.Artigos.Add(art);
            
            Editora edt = new Editora();
            edt.Nome = "Science";
            edt.Cnpj = "000000000";
            edt.Revistas.Add(rev);

            edt.imprimirDados();
        }

        private void btnColaboradorMatriculaDepartamento_Click(object sender, EventArgs e)
        {
            Matricula mat = new Matricula();
            mat.Cod = 1;
            mat.Periodo = DateTime.Now;

            Colaborador col = new Colaborador();
            col.Nome = "Aragorn";
            col.Funcao = "Guardião";
            col.Matricula = mat;

            Departamento dep = new Departamento();
            dep.Cod = 100;
            dep.Nome = "Terra Média";
            dep.Colaboradores.Add(col);

            dep.imprimirDados();
        }

        private void btnUsuarioEditor_Click(object sender, EventArgs e)
        {
            Editor edt = new Editor();
            edt.Nome = "Clark K.";
            edt.Email = "super@jl.int";
            edt.Assinatura = "Super...";

            edt.imprimirDados();
        }

        private void btniTransferenciaSaque_Click(object sender, EventArgs e)
        {
            Saque saq = new Saque();
            saq.Conta = 100;
            saq.Data = DateTime.Now;

            saq.imprimirDados();
            saq.transferir();
        }
    }
}
