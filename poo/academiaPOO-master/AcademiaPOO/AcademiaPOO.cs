using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaPOO
{
    public partial class academiaPOO : Form
    {
        Franquia franquia = new Franquia("", "", "", "", "", new List<Area>(), new List<Aluno>(), new List<Professor>(), new List<Treinador>());
        Area area = new Area(0, "", new List<Equipamento>(), new List<Aula>());
        Aula aula = new Aula("", new Area(), new Professor(), Convert.ToDateTime("2020-05-03"), new List<Aluno>());
        Treino treino = new Treino("", new Aluno(), new Treinador(), Convert.ToDateTime("2020-05-03"), Convert.ToDateTime("2020-05-03"), new List<Equipamento>());
        Aluno aluno = new Aluno(0, "", "", "", "", 0, Convert.ToDateTime("2020-05-03"), Convert.ToDateTime("2020-05-03"), new List<Treino>(), new List<Aula>() );
        Professor professor = new Professor(0, "", "", "", "", "", new List<Aluno>(), new List<Aula>());
        Treinador treinador = new Treinador(0, "", "", "", "", new List<Treino>(), new List<Aluno>());


        public academiaPOO()
        {
            InitializeComponent();
        }

        private void btnFranquia_Click(object sender, EventArgs e)
        {

            this.franquia = new Franquia("DumbFit", "dumbfit.com.br", "123.123.0001-90", "Rua Y, ABC - São Paulo - SP", "12345-1234", new List<Area>(), new List<Aluno>(), new List<Professor>(), new List<Treinador>()); ;

            this.franquia.imprimirDados();
        }

        private void btnAreaFranquia_Click(object sender, EventArgs e)
        {
            this.franquia.inserirArea(new Area(02, "Aeróbica", new List<Equipamento>(), new List<Aula>()));
            this.franquia.imprimirDados();
        }

        private void btnProfessorFranquia_Click(object sender, EventArgs e)
        {
            this.franquia.inserirProfessor(new Professor(
                02,
                "Pasqualete",
                "16 99292-9292",
                "pasqualete@multiplaescolha.com.br",
                "Rua G - Morumbi - São Paulo / SP",
                "Musculação",
                new List<Aluno>(),
                new List<Aula>()
                )
            );
            this.franquia.imprimirDados();
        }

        private void btnTreinadorFranquia_Click(object sender, EventArgs e)
        {
            this.franquia.inserirTreinador(new Treinador(
                03,
                "Coach Renato",
                "16 99393-9393",
                "renato@multiplaescolha.com.br",
                "Rua H - Bom Sucesso - São Paulo / SP",
                new List<Treino>(),
                new List<Aluno>()
                )
            );
            this.franquia.imprimirDados();
        }

        private void btnAlunoFranquia_Click(object sender, EventArgs e)
        {
            this.franquia.inserirAluno(new Aluno(
                07,
                "Rodrigo",
                "16 99191-9191",
                "rodrigo@gmail.com",
                "Rua K - Cidade Ademar - São Paulo / SP",
                001,
                Convert.ToDateTime("2020-01-01"),
                Convert.ToDateTime("2020-02-02"),
                new List<Treino>(),
                new List<Aula>()
                )
            );
            this.franquia.imprimirDados();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
          
            this.area = new Area(01, "Musculação", new List<Equipamento>(), new List<Aula>());
           
            this.area.imprimirDados();
        }

        private void btnEquipamentoArea_Click(object sender, EventArgs e)
        {
            this.area.inserirEquipamento(new Equipamento(69, "supino", "Peitoral", "Ativo", "ForçaMAX"));
            this.area.imprimirDados();
        }

        private void btnAulaArea_Click(object sender, EventArgs e)
        {
            this.area.inserirAula(new Aula(
                "Funcional",
                new Area(04, "Aquecimento", new List<Equipamento>(), new List<Aula>()),
                new Professor(
                    05,
                    "Aristoteles",
                    "16 99494-9494",
                    "aristoteles@greciaantiga.com",
                    "Rua Sparta, 300",
                    "Filosofia do músculo",
                    new List<Aluno>(),
                    new List<Aula>()
                    ),
                Convert.ToDateTime("2020-03/01"),
                new List<Aluno>())
                );
            this.area.imprimirDados();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
           

            this.aluno = new Aluno(
                01,
                "Rogério",
                "16 99191-9191",
                "rogerio@gmail.com",
                "Rua Y - Liberdade - São Paulo / SP",
                001,
                Convert.ToDateTime("2020-01-01"),
                Convert.ToDateTime("2020-02-02"),
                new List<Treino>(),
                new List<Aula>()
            );

            this.aluno.imprimirDados();
        }

        private void btnTreinoAluno_Click(object sender, EventArgs e)
        {
            this.aluno.inserirTreino(new Treino(
                "Musculação",
                new Aluno(
                    01,
                    "Raquel",
                    "11 987456321",
                    "raquel@fatec.com",
                    "Rua P, Favela - São Paulo / SP",
                    078,
                    Convert.ToDateTime("2020-05-01"),
                    Convert.ToDateTime("2020-09-30"),
                    new List<Treino>(),
                    new List<Aula>()
                ),
                new Treinador(
                    05,
                    "Coach Carter",
                    "16 987456321",
                    "treinoparavida@filme.com",
                    "Rua D, Batman, São Paulo / SP",
                    new List<Treino>(),
                    new List<Aluno>()
                ),
                Convert.ToDateTime("2020-01-05"),
                Convert.ToDateTime("2020-06-29"),
                new List<Equipamento>()
                )
            );
            this.aluno.imprimirDados();
        }

        private void btnAulaAluno_Click(object sender, EventArgs e)
        {
            this.aluno.inserirAula(new Aula(
                "Funcional",
                new Area(04, "Aquecimento", new List<Equipamento>(), new List<Aula>()),
                new Professor(
                    05,
                    "Aristoteles",
                    "16 99494-9494",
                    "aristoteles@greciaantiga.com",
                    "Rua Sparta, 300",
                    "Filosofia do músculo",
                    new List<Aluno>(),
                    new List<Aula>()
                    ),
                Convert.ToDateTime("2020-03/01"),
                new List<Aluno>()
                )
            );
            this.aluno.imprimirDados();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            this.professor = new Professor(
                02,
                "Pasquali",
                "16 99292-9292",
                "pasquali@multiplaescolha.com.br",
                "Rua Z - Mooca - São Paulo / SP",
                "Musculação",
                new List<Aluno>(),
                new List<Aula>()
            );

            this.professor.imprimirDados();
        }

        private void btnAlunoProfessor_Click(object sender, EventArgs e)
        {
            this.professor.inserirAluno(new Aluno(
                    01,
                    "Raquel",
                    "11 987456321",
                    "raquel@fatec.com",
                    "Rua P, Favela - São Paulo / SP",
                    078,
                    Convert.ToDateTime("2020-05-01"),
                    Convert.ToDateTime("2020-09-30"),
                    new List<Treino>(),
                    new List<Aula>()
                )
            );
            this.professor.imprimirDados();
        }

        private void btnAulaProfessor_Click(object sender, EventArgs e)
        {
            this.professor.inserirAula(new Aula(
                "Funcional",
                new Area(04, "Aquecimento", new List<Equipamento>(), new List<Aula>()),
                new Professor(
                    05,
                    "Aristoteles",
                    "16 99494-9494",
                    "aristoteles@greciaantiga.com",
                    "Rua Sparta, 300",
                    "Filosofia do músculo",
                    new List<Aluno>(),
                    new List<Aula>()
                    ),
                Convert.ToDateTime("2020-03/01"),
                new List<Aluno>()
                )
            );
            this.professor.imprimirDados();
        }

        private void btnTreinador_Click(object sender, EventArgs e)
        {
            this.treinador = new Treinador(
                03,
                "Coach Carter",
                "16 99393-9393",
                "carter@multiplaescolha.com.br",
                "Rua W - Ipanema - São Paulo / SP",
                new List<Treino>(),
                new List<Aluno>()
            );

            this.treinador.imprimirDados();
           
        }

        private void btnAlunoTreinador_Click(object sender, EventArgs e)
        {
            this.treinador.inserirAluno(new Aluno(
                    01,
                    "Rita",
                    "11 987456321",
                    "rita@fatec.com",
                    "Rua M, Favela - São Paulo / SP",
                    078,
                    Convert.ToDateTime("2020-05-01"),
                    Convert.ToDateTime("2020-09-30"),
                    new List<Treino>(),
                    new List<Aula>()
                )
            );
            this.treinador.imprimirDados();
        }

        private void btnTreinoTreinador_Click(object sender, EventArgs e)
        {
            this.treinador.inserirTreino(new Treino(
                "Funcional",
                new Aluno(
                    01,
                    "Rosana",
                    "11 987456321",
                    "Rosana@fatec.com",
                    "Rua L, Favela - São Paulo / SP",
                    078,
                    Convert.ToDateTime("2020-05-01"),
                    Convert.ToDateTime("2020-09-30"),
                    new List<Treino>(),
                    new List<Aula>()
                ),
                new Treinador(
                    05,
                    "Coach Plotze",
                    "16 987456321",
                    "treinoparavida@filme.com",
                    "Rua D, Batman, São Paulo / SP",
                    new List<Treino>(),
                    new List<Aluno>()
                ),
                Convert.ToDateTime("2020-01-05"),
                Convert.ToDateTime("2020-06-29"),
                new List<Equipamento>()
                )
            );
            this.treinador.imprimirDados();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            this.aula = new Aula(
                "Funcional",
                new Area(04, "Aquecimento", new List<Equipamento>(), new List<Aula>()),
                new Professor(
                    05,
                    "Aristoteles",
                    "16 99494-9494",
                    "aristoteles@greciaantiga.com",
                    "Rua Sparta, 300",
                    "Filosofia do músculo",
                    new List<Aluno>(),
                    new List<Aula>()
                    ),
                Convert.ToDateTime("2020-03/01"),
                new List<Aluno>()
            );

            this.aula.imprimirDados();
        }

        private void btnAlunoAula_Click(object sender, EventArgs e)
        {
            this.aula.inserirAluno(
                new Aluno(
                    01,
                    "Ricardo",
                    "11 987456321",
                    "ricardo@fatec.com",
                    "Rua C, Favela - São Paulo / SP",
                    078,
                    Convert.ToDateTime("2020-05-01"),
                    Convert.ToDateTime("2020-09-30"),
                    new List<Treino>(),
                    new List<Aula>()
                )
            );
            this.aula.imprimirDados();
        }

        private void btnTreino_Click(object sender, EventArgs e)
        {
            this.treino = new Treino(
                "aerobica",
                new Aluno(
                    01,
                    "Richarlison",
                    "11 987456321",
                    "richarlison@fatec.com",
                    "Rua U, Favela - São Paulo / SP",
                    078,
                    Convert.ToDateTime("2020-05-01"),
                    Convert.ToDateTime("2020-09-30"),
                    new List<Treino>(),
                    new List<Aula>()
                ),
                new Treinador(
                    05,
                    "Coach Carter TOP",
                    "16 987456321",
                    "treinoparavida@filme.com",
                    "Rua D, Batman, São Paulo / SP",
                    new List<Treino>(),
                    new List<Aluno>()
                ),
                Convert.ToDateTime("2020-01-05"),
                Convert.ToDateTime("2020-06-29"),
                new List<Equipamento>()
            );

            this.treino.imprimirDados();

        }

        private void btnEquipamentoTreino_Click(object sender, EventArgs e)
        {
            this.treino.inserirEquipamento(new Equipamento(69, "supino", "Peitoral", "Ativo", "ForçaMAX"));
            this.treino.imprimirDados();
        }

        private void btnImprimirEquipamentoArea_Click(object sender, EventArgs e)
        {
            this.area.imprimirEquipamentos();
        }

        private void btnImprimirAulaArea_Click(object sender, EventArgs e)
        {
            this.area.imprimirAulas();
        }
    }
}
