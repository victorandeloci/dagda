using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Governador
{
    public string nome;
    public string cpf;
    public Estado estado;

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("CPF: " + this.cpf);

        if(estado != null)
        {
            estado.imprimirDados();
        }
    }
}
