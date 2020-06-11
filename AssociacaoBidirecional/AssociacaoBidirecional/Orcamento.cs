using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Orcamento
{
    private int numero;
    private int codigoConsumidor;
    private float valor;

    public void inserirDados(int numero, Consumidor cons, float valor)
    {
        this.numero = numero;
        this.codigoConsumidor = cons.codigo;
        this.valor = valor;
    }

    public void imprimirDados()
    {
        Console.WriteLine("Orçamento: " + this.numero);
        Console.WriteLine("Cód. Consumidor: " + this.codigoConsumidor);
        Console.WriteLine("Valor: " + this.valor);
    }
}
