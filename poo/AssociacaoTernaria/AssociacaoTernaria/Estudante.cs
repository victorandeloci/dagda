using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Estudante{
	public string nome;
	private List<Matricula> matriculas;
	
	public List<Matricula> Matriculas{
		get{
			if(matriculas == null)
				matriculas = new List<Matricula>();
			
			return matriculas;
		}
		set{
			if(matriculas == null)
				matriculas = new List<Matricula>();
			
			matriculas = value;
		}
	}
	
	public void imprimirDados(){
		Console.WriteLine("Nome: " + this.nome);
		if(matriculas != null){
			foreach(Matricula item in matriculas){
				Console.WriteLine("\t Matrícula: " + item.numero);
				Console.WriteLine("\t Disciplina: " + item.disciplina.nome);
			}
		}
	}
}