using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Video {

	private string titulo;
	private double duracao;

	public string Titulo{ get; set; }
	public double Duracao{ get; set; }

	public void imprimirDados()
	{
		Console.WriteLine("\tTítulo: " + Titulo);
		Console.WriteLine("\tDuração: " + Duracao);
	}

}

