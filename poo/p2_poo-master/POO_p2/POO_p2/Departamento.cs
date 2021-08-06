using System.Collections.Generic;

public class Departamento
{
	private string nome;
	private int cod;
	private List<Colaborador> colaboradores;

	public string Nome{ get; set; }
	public int Cod{ get; set; }
	public List<Colaborador> Colaboradores
	{
		get
		{
			if (colaboradores == null)
			{
				colaboradores = new List<Colaborador>();
			}
			return colaboradores;
		}
		set
		{
			if (colaboradores == null)
			{
				colaboradores = new List<Colaborador>();
			}
			colaboradores = value;
		}
	}

	public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("Departamento (Cod): " + Cod);
		if (Colaboradores != null)
		{
			foreach (Colaborador item in Colaboradores)
			{
				item.imprimirDados();
			}
		}
	}

}

