using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Funcionario
{
	public int codigo;
	public string nome;
	public Computador compt;
	public Tablet tablet;

	public void imprimirDados()
	{
		Console.WriteLine("Código do Funcionário: " + this.codigo);
		Console.WriteLine("Nome do Funcionário: " + this.nome);

		Console.WriteLine("Código do Computador: " + this.compt.codigo);
		Console.WriteLine("Descrição do Computador: " + this.compt.descricao);

		Console.WriteLine("Código do Tablet: " + this.tablet.codigo);
		Console.WriteLine("Descrição do Tablet: " + this.tablet.descricao);
	}

}
