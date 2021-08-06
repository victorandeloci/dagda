using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Veiculo
{
    // Atributo
    public string modelo;
    public int nroPortas;
    private Montadora montadora;   

    public Montadora MontadoraV {
        get
        {
            if (montadora == null)
            {
                montadora = new Montadora();
            }
            return montadora;
        }
        set
        {
            if (montadora == null)
            {
                montadora = new Montadora();
            }
            montadora = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Nro Portas: " + nroPortas);
               

        if (montadora != null)
        {
            Console.WriteLine("\t Código: " + montadora.codMontadora);
            Console.WriteLine("\t Nome: " + montadora.nome);
        }
    }
}

