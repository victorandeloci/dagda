using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Gerente : Colaborador
{
    private string setor;

    public string Setor { get => setor; set => setor = value; }

    public Gerente() { }

    public Gerente(string nome, string cpf, float salario, string setor)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.salario = salario;
        this.setor = setor;
    }

    public virtual void CalcularPLR()
    {
        Console.WriteLine("PLR: " + this.Salario * 0.2f);
    }

}
