using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cliente
{
    public string nome;
    public string cidade;

    public void imprimirDados()
    {
        Console.WriteLine("\t Nome: " + this.nome);
        Console.WriteLine("\t Cidade: " + this.cidade);
    }
}
