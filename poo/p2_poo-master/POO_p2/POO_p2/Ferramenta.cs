public class Ferramenta
{
	private int codEquipamento;

	private string descricao;

	public int CodEquipamento{ get; set; }

	public string Descricao{ get; set; }

	public void imprimirDados()
	{
		System.Console.WriteLine("\tC�digo do Equipamento: " + CodEquipamento);
		System.Console.WriteLine("\tDescri��o: " + Descricao);
	}

}

