using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Matricula{
	public int numero;
	
	public Estudante estudante = new Estudante();
	public Disciplina disciplina = new Disciplina();
	
	public void imprimirDados(){
		Console.WriteLine("Número da Matrícula: " + numero);
		Console.WriteLine("Estudante: " + estudante.nome);
		Console.WriteLine("Disciplina: " + disciplina.nome);
	}
}