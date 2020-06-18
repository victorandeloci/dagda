using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Pessoa
{
    protected string nome;
    protected float salario;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public abstract float Salario { get; set; }

    public virtual void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário Base: " + salario.ToString("N2"));
    }
}
