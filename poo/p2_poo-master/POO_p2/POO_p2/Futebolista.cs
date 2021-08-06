using System.Collections.Generic;

public class Futebolista
{
	private string nome;
	private string posicao;
	private List<Jogo> jogos;
	private Clube clube;

	public string Nome{ get; set; }
	public string Posicao{ get; set; }
	public List<Jogo> Jogos
	{
		get
		{
			if(jogos == null)
			{
				jogos = new List<Jogo>();
			}
			return jogos;
		}
		set
		{
			if (jogos == null)
			{
				jogos = new List<Jogo>();
			}
			jogos = value;
		}
	}
	public Clube Clube { get => clube; set => clube = value; }

	public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("Posição: " + Posicao);
		Clube.imprimirDados();
		if(Jogos != null)
		{
			foreach(Jogo item in Jogos)
			{
				item.imprimirDados();
			}
		}
	}

}

