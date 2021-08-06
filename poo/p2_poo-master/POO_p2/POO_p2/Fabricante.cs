using System.Collections.Generic;

public class Fabricante
{
	private string nome;
	private string cnpj;
	private List<InstrumentoMusical> instrumentos;

	public string Nome{ get; set; }
	public string Cnpj{ get; set; }
	public List<InstrumentoMusical> Instrumentos {
		get
		{
			if(instrumentos == null)
			{
				instrumentos = new List<InstrumentoMusical>();
			}
			return instrumentos;
		}
		set
		{
			if (instrumentos == null)
			{
				instrumentos = new List<InstrumentoMusical>();
			}
			instrumentos = value;
		}
	}

	public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("CNPJ: " + Cnpj);
		if(Instrumentos != null)
		{
			foreach(InstrumentoMusical item in Instrumentos)
			{
				item.imprimirDados();
			}
		}
	}

}

