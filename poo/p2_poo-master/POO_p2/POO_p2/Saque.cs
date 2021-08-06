using System;

public class Saque : iTransferencia
{
	private int conta;
	private DateTime data;

	public int Conta{ get; set; }
	public DateTime Data { get; set; }

	public void transferir()
	{
		Console.WriteLine("De CONTA X para CONTA Y");
	}

	public void imprimirDados()
	{
		System.Console.WriteLine("Conta: " + Conta);
		System.Console.WriteLine("Data: " + Data);
	}

}

