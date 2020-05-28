using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Estado
{
    public string nome;
    public string uf;
    public Governador governador;

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("UF: " + this.uf);

        if (governador != null)
        {
            governador.imprimirDados();
        }
    }
}
