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

        private void btnMontadoraVeidulo_Click(object sender, EventArgs e)
        {
            Veiculo o_Civic = new Veiculo();
            o_Civic.modelo = "Civic";
            o_Civic.nroPortas = 4;

            Veiculo o_City = new Veiculo();
            o_City.modelo = "City";
            o_City.nroPortas = 4;

            Montadora o_Montadora = new Montadora();
            o_Montadora.codMontadora = 100;
            o_Montadora.nome = "Honda";

            // De Montadora para Veículo
            o_Montadora.Veiculos.Add(o_Civic);  // RELACIONAMENTO
            o_Montadora.Veiculos.Add(o_City);   // RELACIONAMENTO

            // De Veículo para Montadora
            o_Civic.MontadoraV = o_Montadora;   // RELACIONAMENTO
            o_City.MontadoraV = o_Montadora;    // RELACIONAMENTO

            Console.WriteLine("<--- MONTADORA --->");
            o_Montadora.imprimirDados();

            Console.WriteLine("<--- VEÍCULOS --->");
            o_Civic.imprimirDados();
            o_City.imprimirDados();
        }

        private void btnProfRegistro_Click(object sender, EventArgs e)
        {
            Professor o_Maria = new Professor();
            o_Maria.nome = "Maria";
            o_Maria.idade = 45;

            Professor o_Jose = new Professor();
            o_Jose.nome = "José";
            o_Jose.idade = 50;

            Professor o_Pedro = new Professor();
            o_Pedro.nome = "Pedro";
            o_Pedro.idade = 55;

            // Coordenadora
            o_Maria.Professores.Add(o_Jose);    // RELACIONAMENTO
            o_Maria.Professores.Add(o_Pedro);   // RELACIONAMENTO

            // Professores
            o_Jose.Coordenador = o_Maria;   // RELACIONAMENTO 
            o_Pedro.Coordenador = o_Maria;  // RELACIONAMENTO

            Console.WriteLine("<--- COORDENADOR --->");
            o_Maria.imprimirDados();

            Console.WriteLine("<--- PROFESSORES --->");
            o_Jose.imprimirDados();
            o_Pedro.imprimirDados();
        }

        private void btnRegistroCivil_Click(object sender, EventArgs e)
        {
            RegistroCivil o_Esposa = new RegistroCivil();
            o_Esposa.nome = "Maria";
            o_Esposa.idade = 20;

            RegistroCivil o_Marido = new RegistroCivil();
            o_Marido.nome = "José";
            o_Marido.idade = 25;

            o_Esposa.Conjuge = o_Marido;    // RELACIONAMENTO
            o_Marido.Conjuge = o_Esposa;    // RELACIONAMENTO

            Console.WriteLine("<--- ESPOSA --->");
            o_Esposa.imprimirDados();

            Console.WriteLine("<--- MARIDO --->");
            o_Marido.imprimirDados();
        }
    }
}
