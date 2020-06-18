using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Representante : Pessoa
{
    private float comissao;

    public float Comissao
    {
        get
        {
            return comissao;
        }
        set
        {
            comissao = value;
        }
    }

    public override float Salario
    {
        get
        {
            return salario;
        }
        set
        {
            salario = value + 500f;
        }
    }

    public override void imprimirDados()
    {
        base.imprimirDados();

        Console.WriteLine("Comissão: " + comissao.ToString("N2"));
    }

    public float participacaoLucros()
    {
        return 500f;
    }
}
