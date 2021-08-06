public class Cliente
{
	private int cpf;
	private string nome;

	public string Nome{ get; set; }
	public string Cpf{ get; set; }

	public void imprimirDados()
	{
		System.Console.WriteLine("\tNome: " + Nome);
		System.Console.WriteLine("\tCPF: " + Cpf);
	}

}

