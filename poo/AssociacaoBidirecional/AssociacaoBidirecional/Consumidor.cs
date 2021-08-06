using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Consumidor{
	public int codigo;
	public string nome;
	public string cep;
	public string cidade;

	public void inserirDados(int condigo, string nome, string cep){
		Correios correio = new Correios();

		this.codigo = codigo;
		this.nome = nome;
		this.cep = cep;
		cidade = correio.obterCidade(cep);
	}

	public void imprimirDados()
	{
		Console.WriteLine("Código: " + codigo);
		Console.WriteLine("Nome: " + nome);
		Console.WriteLine("CEP: " + cep);
		Console.WriteLine("Cidade: " + cidade);
	}
}