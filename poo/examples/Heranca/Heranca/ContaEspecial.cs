using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ContaEspecial : Conta
{
    private float credito;

    public float Credito { get => credito; set => credito = value; }

    public new void ImprimirDados()
    {
        Console.WriteLine("Número da Conta: " + this.NumConta);
        Console.WriteLine("Nome: " + this.NomeCliente);
        Console.WriteLine("Saldo: " + this.SaldoConta);
        Console.WriteLine("Crédito disponível: " + this.Credito);
    }

    public new void Sacar(float valor)
    {
        if (valor > (this.SaldoConta + this.Credito))
            throw new Exception("Saldo insuficiente");
        else
            this.SaldoConta -= valor;
    }

}
