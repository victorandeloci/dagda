using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Colaborador
{
    protected string nome;
    protected string cpf;
    protected float salario;

    public string Nome { get => nome; set => nome = value; }
    public string Cpf { get => cpf; set => cpf = value; }
    public float Salario { get => salario; set => salario = value; }

    public Colaborador() { }

    public Colaborador(string nome, string cpf, float salario)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.salario = salario;
    }

    public void CalcularPLR()
    {
        Console.WriteLine("PLR: " + this.Salario * 0.1f);
    }
}
