using System;

public class Jogo
{
	private string campeonato;
	private DateTime data;

	public DateTime Data { get; set; }
	public string Campeonato{ get; set; }

	public void imprimirDados()
	{
		System.Console.WriteLine("Campeonato: " + Campeonato);
		System.Console.WriteLine("Data: " + Data);
	}

}

