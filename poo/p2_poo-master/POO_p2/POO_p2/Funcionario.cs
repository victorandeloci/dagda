public class Funcionario
{
	private int codFunc;
	private string nome;
	private Ferramenta ferramenta;

	public Ferramenta Ferramenta { get; set; }

	public int CodFunc{ get; set; }

	public string Nome{ get; set; }

	public void imprimirDados()
	{
		System.Console.WriteLine("Código: " + CodFunc);
		System.Console.WriteLine("Nome: " + Nome);
		Ferramenta.imprimirDados();
	}

}

