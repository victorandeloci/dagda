using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Reuniao{
	public string titulo;
	public DateTime horario;
	private List<Funcionario> participantes;
	
	public List<Funcionario> Participantes{
		get{
			if(participantes == null)
				participantes = new List<Funcionario>();

			return participantes;
		}
		set{
			if(participantes == null)
				participantes = new List<Funcionario>();
				
			participantes = value;
		}
	}
	
	public void imprimirDados(){
		Console.WriteLine("Título: " + this.titulo);
		Console.WriteLine("Horário: " + this.horario);
		
		if(this.participantes != null)
			foreach(Funcionario item in this.participantes)
				Console.WriteLine("\t Nome: " + item.nome);
	}
}