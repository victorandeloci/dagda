using System.Collections.Generic;

public class Editor : Usuario
{
	private List<Post> posts;
	private string assinatura;

	public List<Post> Posts{ get; set; }
	public string Assinatura{ get; set; }
	public override string Nome { get; set; }
	public override string Email { get; set; }

	override public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("E-mail: " + Email);
		System.Console.WriteLine("Assinatura: " + Assinatura);
	}

}

