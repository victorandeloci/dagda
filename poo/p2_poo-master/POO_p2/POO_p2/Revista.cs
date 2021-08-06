using System.Collections.Generic;

public class Revista
{
	private string nome;
	private int edicao;
	private List<Artigo> artigos;

	public string Nome{ get; set; }
	public int Edicao{ get; set; }
	public List<Artigo> Artigos
	{
		get
		{
			if (artigos == null)
			{
				artigos = new List<Artigo>();
			}
			return artigos;
		}
		set
		{
			if (artigos == null)
			{
				artigos = new List<Artigo>();
			}
			artigos = value;
		}
	}

	public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("Edição: " + Edicao);
		if (Artigos != null)
		{
			foreach (Artigo item in Artigos)
			{
				item.imprimirDados();
			}
		}
	}

}

