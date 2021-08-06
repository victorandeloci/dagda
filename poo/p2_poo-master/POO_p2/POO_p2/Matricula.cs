using System;

public class Matricula
{
	private int cod;
	private DateTime periodo;

	public int Cod { get => cod; set => cod = value; }
	public DateTime Periodo { get => periodo; set => periodo = value; }

	public void imprimirDados()
	{
		System.Console.WriteLine("\t\tCod de Matrícula: " + Cod);
		System.Console.WriteLine("\t\tPeríodo: " + Periodo);
	}

}

