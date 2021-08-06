using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Computador
{

	public int codigo;
	public string descricao;

	public void imprimirDados()
	{
		Console.WriteLine("Código do Computador: " + this.codigo);
		Console.WriteLine("Descrição do Computador: " + this.descricao);
	}

}
