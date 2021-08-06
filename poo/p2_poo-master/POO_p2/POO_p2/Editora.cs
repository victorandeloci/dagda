using System.Collections.Generic;

public class Editora
{
	private string nome;
	private string cnpj;
	private List<Revista> revistas;

	public string Nome{ get; set; }
	public string Cnpj{ get; set; }
	public List<Revista> Revistas
	{
		get
		{
			if (revistas == null)
			{
				revistas = new List<Revista>();
			}
			return revistas;
		}
		set
		{
			if (revistas == null)
			{
				revistas = new List<Revista>();
			}
			revistas = value;
		}
	}

	public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("CNPJ: " + Cnpj);
		if (Revistas != null)
		{
			foreach (Revista item in Revistas)
			{
				item.imprimirDados();
			}
		}
	}

}

