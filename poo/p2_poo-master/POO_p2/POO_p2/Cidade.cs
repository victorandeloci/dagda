public class Cidade
{
	private string nome;
	private string uF;
	private Prefeito prefeito;

	public string Nome{ get; set; }
	public string UF{ get; set; }
	public Prefeito Prefeito { get => prefeito; set => prefeito = value; }

	public void imprimirDados()
	{
		System.Console.WriteLine("\tNome: " + Nome);
		System.Console.WriteLine("\tUF: " + UF);
	}

}

