using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ContaEspecial : Conta
{
    private float credito;

    public float Credito { get => credito; set => credito = value; }

    public void imprimeCredito()
    {
        Console.WriteLine("Crédito disponível: " + this.Credito);
    }

}
