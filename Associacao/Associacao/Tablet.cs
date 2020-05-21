using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tablet
{

	public int codigo;
	public string descricao;

	public void imprimirDados()
	{
		Console.WriteLine("Código do Tablet: " + this.codigo);
		Console.WriteLine("Descrição do Tablet: " + this.descricao);
	}

}
