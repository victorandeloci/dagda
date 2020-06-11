using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aeronave
{
    public int codigo;
    public string modelo;
    private List<TrechoVoo> trechos;

    internal List<TrechoVoo> Trechos {
        get
        {
            if (trechos == null)
            {
                trechos = new List<TrechoVoo>();
            }
            return trechos;
        }
        set
        {
            if (trechos == null)
            {
                trechos = new List<TrechoVoo>();
            }
            trechos = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Código: " + this.codigo);
        Console.WriteLine("Modelo: " + this.modelo);

        if (this.Trechos != null)
        {
            foreach (TrechoVoo item in this.Trechos)
            {
                item.imprimirDados();
            }
        }
    }
}
