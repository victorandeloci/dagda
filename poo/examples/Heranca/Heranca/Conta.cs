using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Conta
{
    protected int numConta;
    protected string nomeCliente;
    protected float saldoConta;

    public int NumConta { get => numConta; set => numConta = value; }
    public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
    public float SaldoConta { get => saldoConta; set => saldoConta = value; }

    public void depositar(float valor)
    {
        this.SaldoConta += valor;
    }

    public void Sacar(float valor)
    {
        if(valor > this.SaldoConta)
            throw new Exception("Saldo insuficiente");
        else
            this.SaldoConta -= valor;
    }

    public void ImprimirDados()
    {
        Console.WriteLine("Número da Conta: " + this.NumConta);
        Console.WriteLine("Nome: " + this.NomeCliente);
        Console.WriteLine("Saldo: " + this.SaldoConta);
    }

}
