using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vendedor
{
    public int codigo;
    public string nome;
    private List<Cliente> clientes;

    public List<Cliente> Clientes {
        get
        {
            if(clientes == null)
            {
                clientes = new List<Cliente>();
            }
            return clientes;
        }
        set
        {
            if(clientes == null)
            {
                clientes = new List<Cliente>();
            }
            clientes = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Código: " + this.codigo);
        Console.WriteLine("Nome: " + this.nome);

        if(this.Clientes != null)
        {
            foreach(Cliente item in this.Clientes)
            {
                item.imprimirDados();
            }
        }
    }
}
