public class Colaborador
{
	private string nome;
	private string funcao;
	private Matricula matricula;

	public string Nome{ get; set; }
	public string Funcao{ get; set; }
	public Matricula Matricula { get => matricula; set => matricula = value; }

	public void imprimirDados()
	{
		System.Console.WriteLine("\tNome: " + Nome);
		System.Console.WriteLine("\tFunção: " + Funcao);
		Matricula.imprimirDados();
	}

}

