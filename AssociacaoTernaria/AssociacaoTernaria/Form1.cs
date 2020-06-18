using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssociacaoTernaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstMatDisc_Click(object sender, EventArgs e)
        {
            Disciplina poo = new Disciplina();
            poo.nome = "Prog. Orientada a Objetos";

            Disciplina adm = new Disciplina();
            adm.nome = "Charlote";

            Estudante gandalf = new Estudante();
            gandalf.nome = "O Mago Cinzento";

            Estudante tordo = new Estudante();
            tordo.nome = "Katniss Everdeen";

            Matricula mat_1 = new Matricula();
            mat_1.numero = 100;
            mat_1.disciplina = poo;
            gandalf.Matriculas.Add(mat_1);

            Matricula mat_2 = new Matricula();
            mat_2.numero = 200;
            mat_2.disciplina = adm;
            tordo.Matriculas.Add(mat_2);

            gandalf.imprimirDados();
            tordo.imprimirDados();
        }
    }
}
