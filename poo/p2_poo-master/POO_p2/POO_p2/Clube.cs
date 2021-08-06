public class Clube
{
	private string nome;
	private string mascote;

	public string Nome{ get; set; }
	public string Mascote{ get; set; }

	public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("Mascote: " + Mascote);
	}

}

