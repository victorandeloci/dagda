public class Ferramenta
{
	private int codEquipamento;

	private string descricao;

	public int CodEquipamento{ get; set; }

	public string Descricao{ get; set; }

	public void imprimirDados()
	{
		System.Console.WriteLine("\tCódigo do Equipamento: " + CodEquipamento);
		System.Console.WriteLine("\tDescrição: " + Descricao);
	}

}

