public class Prefeito
{
	private string nome;
	private string legenda;
	private Cidade cidade;

	public string Nome{ get; set; }
	public string Legenda{ get; set; }
	public Cidade Cidade { get => cidade; set => cidade = value; }

	public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("Legenda: " + Legenda);
		Cidade.imprimirDados();
	}

}

