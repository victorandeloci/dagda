public class InstrumentoMusical
{
	private string nome;
	private string tipo;
	private Fabricante fabricante;

	public string Nome{ get; set; }
	public string Tipo{ get; set; }
	public Fabricante Fabricante { get => fabricante; set => fabricante = value; }

	public void imprimirDados()
	{
		System.Console.WriteLine("\tNome: " + Nome);
		System.Console.WriteLine("\tTipo: " + Tipo);
	}

}

