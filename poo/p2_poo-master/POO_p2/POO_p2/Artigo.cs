public class Artigo
{
	private string nome;
	private string descricao;

	public string Nome{ get; set; }
	public string Descricao{ get; set; }

	public void imprimirDados()
	{
		System.Console.WriteLine("\tNome: " + Nome);
		System.Console.WriteLine("\tDescrição: " + Descricao);
	}

}

