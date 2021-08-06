using System.Collections.Generic;

public class Restaurante
{
	private string nome;
	private string endereco;
	private List<Cliente> clientes;

	public string Nome{ get; set; }
	public string Endereco{ get; set; }
    public List<Cliente> Clientes
    {
        get
        {
            if (clientes == null)
            {
                clientes = new List<Cliente>();
            }
            return clientes;
        }
        set
        {
            if (clientes == null)
            {
                clientes = new List<Cliente>();
            }
            clientes = value;
        }
    }

    public void imprimirDados()
	{
		System.Console.WriteLine("Nome: " + Nome);
		System.Console.WriteLine("Endereço: " + Endereco);
        if (Clientes != null)
        {
            foreach (Cliente item in Clientes)
            {
                item.imprimirDados();
            }
        }
    }

}

